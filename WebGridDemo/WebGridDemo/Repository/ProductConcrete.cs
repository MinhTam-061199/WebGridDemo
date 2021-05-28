using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebGridDemo.Models;

namespace WebGridDemo.Repository
{
    public class ProductConcrete : IProduct
    {
        public int GetProductsCount(string Search)
        {
            using (SqlConnection con = new SqlConnection(ShareConnectionString.Value))
            {
                var para = new DynamicParameters();
                para.Add("@Search", Search);
                var data = con.Query<int>("GetProductCount_Search", para, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return data;
            }
        }

        public List<Product> ProductPagination(string Search, string orderBy, int? pageNumber, int pageSize)
        {
            using (SqlConnection con = new SqlConnection(ShareConnectionString.Value))
            {
                var para = new DynamicParameters();
                para.Add("@orderBy", orderBy);
                para.Add("@PageNumber", pageNumber);
                para.Add("@PageSize", pageSize);
                para.Add("@Search", Search);
                var data = con.Query<Product>("ProductPagination_Search", para, commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
       

    }
}

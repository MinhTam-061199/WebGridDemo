using System.Collections.Generic;
using WebGridDemo.Models;

namespace WebGridDemo.Repository
{
    public interface IProduct
    {
        int GetProductsCount(string Search);
        List<Product> ProductPagination(string Search, string orderBy, int? pageNumber, int pageSize);
    }
}

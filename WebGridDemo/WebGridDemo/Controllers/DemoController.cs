using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using WebGridDemo.Models;
using WebGridDemo.Repository;
using X.PagedList;

namespace WebGridDemo.Controllers
{
    public class DemoController : Controller
    {
        IProduct _IProduct;
        public DemoController(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public IActionResult Grid(string Search, int sortby, bool isAsc = true, int? page = 1)
        {
            string SearchValue = string.Empty;
            if (!string.IsNullOrEmpty(Search))
            {
                SearchValue = Regex.Replace(Search, @"[^a-zA-Z0-9\s]", string.Empty);
            }

            if (page < 0)
            {
                page = 1;
            }

            ProductPagingInfo ProductPagingInfo = new ProductPagingInfo();
            var pageIndex = (page ?? 1) - 1;
            var pageSize = 5;

            string sortColumn;
            #region SortingColumn
            switch (sortby)
            {
                case 1:
                    if (isAsc)
                        sortColumn = "ProductId";
                    else
                        sortColumn = "ProductId Desc";
                    break;

                case 2:
                    if (isAsc)
                        sortColumn = "Name";
                    else
                        sortColumn = "Name Desc";
                    break;

                case 3:
                    if (isAsc)
                        sortColumn = "Price";
                    else
                        sortColumn = "Price Desc";
                    break;
                default:
                    sortColumn = "ProductId asc";
                    break;

            }
            #endregion

            int totalProductCount = _IProduct.GetProductsCount(SearchValue);
            var products = _IProduct.ProductPagination(SearchValue, sortColumn, page, pageSize).ToList();
            var productsPagedList = new StaticPagedList<Product>(products, pageIndex + 1, pageSize, totalProductCount);
            ProductPagingInfo.Products = productsPagedList;
            ProductPagingInfo.pageSize = page;
            ProductPagingInfo.sortBy = sortby;
            ProductPagingInfo.isAsc = isAsc;
            ProductPagingInfo.Search = SearchValue;
            return View(ProductPagingInfo);


        }
      
    }
    }

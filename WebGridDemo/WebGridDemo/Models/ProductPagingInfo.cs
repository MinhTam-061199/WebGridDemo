using X.PagedList;

namespace WebGridDemo.Models
{
    public class ProductPagingInfo
    {
        public int? pageSize;
        public int sortBy;
        public string Search;
        public bool isAsc { get; set; }
        public StaticPagedList<Product> Products { get; set; }
    }
}

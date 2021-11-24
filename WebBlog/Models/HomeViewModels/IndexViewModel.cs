using PagedList.Core;
using WebBlog.Data.Models;

namespace WebBlog.Models.HomeViewModels
{
    public class IndexViewModel
    {
        public IPagedList<Post> Posts { get; set; }
        public string SearchString { get; set; }
        public int PageNumber { get; set; }
    }
}

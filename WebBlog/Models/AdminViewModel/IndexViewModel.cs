using System.Collections.Generic;
using WebBlog.Data.Models;

namespace WebBlog.Models.AdminViewModel
{
    public class IndexViewModel
    {
        public IEnumerable<Blog> Blogs { get; set; }
    }
}

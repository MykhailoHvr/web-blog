using System.Collections.Generic;
using System.Threading.Tasks;
using WebBlog.Data.Models;

namespace WebBlog.Service.Interfaces
{
    public interface IBlogService
    {
        Task<Blog> Add(Blog blog);
        IEnumerable<Blog> GetBlogs(ApplicationUser applicationUser);
        Blog GetBlog(int blogId);
        Task<Blog> Update(Blog blog);
    }
}

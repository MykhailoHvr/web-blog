using System.Security.Claims;
using System.Threading.Tasks;
using WebBlog.Data.Models;
using WebBlog.Models.BlogViewModels;

namespace WebBlog.BusinessManager.Interfaces
{
    public interface IBlogBusinessManager
    {
        Task<Blog> CreateBlog(CreateBlogViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal);
    }
}

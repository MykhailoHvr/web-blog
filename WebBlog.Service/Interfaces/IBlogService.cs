using System.Threading.Tasks;
using WebBlog.Data.Models;

namespace WebBlog.Service.Interfaces
{
    public interface IBlogService
    {
        Task<Blog> Add(Blog blog);
    }
}

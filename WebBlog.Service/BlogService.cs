using System.Threading.Tasks;
using WebBlog.Data;
using WebBlog.Data.Models;
using WebBlog.Service.Interfaces;

namespace WebBlog.Service
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public BlogService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Blog> Add(Blog blog)
        {
            applicationDbContext.Add(blog);
            await applicationDbContext.SaveChangesAsync();
            return blog;
        }
    }
}

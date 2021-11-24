using System.Collections.Generic;
using System.Threading.Tasks;
using WebBlog.Data.Models;

namespace WebBlog.Service.Interfaces
{
    public interface IPostService
    {
        Task<Post> Add(Post post);
        IEnumerable<Post> GetPosts(ApplicationUser applicationUser);
        Post GetPost(int postId);
        Task<Post> Update(Post post);
        IEnumerable<Post> GetPosts(string searchString);
    }
}

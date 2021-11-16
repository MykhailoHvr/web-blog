using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using WebBlog.BusinessManager.Interfaces;
using WebBlog.Data.Models;
using WebBlog.Models.BlogViewModels;
using WebBlog.Service.Interfaces;

namespace WebBlog.BusinessManager
{
    public class BlogBusinessManager : IBlogBusinessManager
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IBlogService blogService;
        public BlogBusinessManager(UserManager<ApplicationUser> userManager, IBlogService blogService)
        {
            this.userManager = userManager;
            this.blogService = blogService;
        }
        public async Task<Blog> CreateBlog(CreateBlogViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal)
        {
            Blog blog = createBlogViewModel.Blog;
            blog.Creator = await userManager.GetUserAsync(claimsPrincipal);
            blog.CreatedOn = DateTime.Now;

            return await blogService.Add(blog);
        }
    }
}

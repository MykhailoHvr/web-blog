using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;
using WebBlog.BusinessManager.Interfaces;
using WebBlog.Data.Models;
using WebBlog.Models.AdminViewModel;
using WebBlog.Service.Interfaces;

namespace WebBlog.BusinessManager
{
    public class AdminBusinessManager : IAdminBusinessManager
    {
        private UserManager<ApplicationUser> userManager;
        private IBlogService blogService;

        public AdminBusinessManager(UserManager<ApplicationUser> userManager, IBlogService blogService)
        {
            this.userManager = userManager;
            this.blogService = blogService;
        }

        public async Task<IndexViewModel> GetAdminDashboard(ClaimsPrincipal claimPrincipal)
        {
            var applicationUser = await userManager.GetUserAsync(claimPrincipal);
            return new IndexViewModel
            {
                Blogs = blogService.GetBlogs(applicationUser)
            };
        }
    }
}

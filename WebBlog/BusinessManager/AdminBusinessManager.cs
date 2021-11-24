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
        private IPostService postService;

        public AdminBusinessManager(UserManager<ApplicationUser> userManager, IPostService postService)
        {
            this.userManager = userManager;
            this.postService = postService;
        }

        public async Task<IndexViewModel> GetAdminDashboard(ClaimsPrincipal claimPrincipal)
        {
            var applicationUser = await userManager.GetUserAsync(claimPrincipal);
            return new IndexViewModel
            {
                Posts = postService.GetPosts(applicationUser)
            };
        }
    }
}

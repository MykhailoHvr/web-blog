using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebBlog.Data.Models;

namespace WebBlog.Authorization
{
    public class PostAuthoriazationHandler : AuthorizationHandler<OperationAuthorizationRequirement, Post>
    {
        private readonly UserManager<ApplicationUser> userManager;

        public PostAuthoriazationHandler(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }   

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Post resource)
        {
            var applicationUser = await userManager.GetUserAsync(context.User);

            if ((requirement.Name == Operations.Update.Name || requirement.Name == Operations.Delete.Name) && applicationUser == resource.Creator)
            {
                context.Succeed(requirement);
            }
        }
    }
}

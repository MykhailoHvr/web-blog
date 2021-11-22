using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using WebBlog.Data.Models;
using WebBlog.Models.BlogViewModels;

namespace WebBlog.BusinessManager.Interfaces
{
    public interface IBlogBusinessManager
    {
        Task<Blog> CreateBlog(CreateViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> GetEditViewModel(int? id, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> UpdateBlog(EditViewModel editViewModel, ClaimsPrincipal claimsPrincipal);
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using WebBlog.Data.Models;
using WebBlog.Models.PostViewModels;
using WebBlog.Models.HomeViewModels;

namespace WebBlog.BusinessManager.Interfaces
{
    public interface IPostBusinessManager
    {
        Task<Post> CreatePost(CreateViewModel createViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> GetEditViewModel(int? id, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> UpdatePost(EditViewModel editViewModel, ClaimsPrincipal claimsPrincipal);
        IndexViewModel GetIndexViewModel(string searchString, int? page);
    }
}

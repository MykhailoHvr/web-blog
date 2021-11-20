using System.Security.Claims;
using System.Threading.Tasks;
using WebBlog.Models.AdminViewModel;

namespace WebBlog.BusinessManager.Interfaces
{
    public interface IAdminBusinessManager
    {
        Task<IndexViewModel> GetAdminDashboard(ClaimsPrincipal claimPrincipal);
    }
}

using System.Threading.Tasks;
using WebBlog.Data.Models;

namespace WebBlog.Service.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> Update(ApplicationUser applicationUser);
    }
}

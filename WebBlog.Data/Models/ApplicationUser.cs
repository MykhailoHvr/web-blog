using Microsoft.AspNetCore.Identity;

namespace WebBlog.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

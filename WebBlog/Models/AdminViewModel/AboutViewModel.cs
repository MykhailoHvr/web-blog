using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using WebBlog.Data.Models;

namespace WebBlog.Models.AdminViewModel
{
    public class AboutViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }
        [Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        [Display(Name = "Sub-header")]
        public string SubHeader { get; set; }
        public string Content { get; set; }
    }
}

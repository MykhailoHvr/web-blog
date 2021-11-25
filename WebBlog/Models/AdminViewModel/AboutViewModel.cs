using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WebBlog.Models.AdminViewModel
{
    public class AboutViewModel
    {
        [Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        [Display(Name = "Sub-header")]
        public string SubHeader { get; set; }
        public string Content { get; set; }
    }
}

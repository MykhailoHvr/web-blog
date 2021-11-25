using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using WebBlog.Data.Models;

namespace WebBlog.Models.PostViewModels
{
    public class EditViewModel
    {
        [Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        public Post Post { get; set; }
    }
}

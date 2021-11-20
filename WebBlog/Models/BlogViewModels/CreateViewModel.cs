using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using WebBlog.Data.Models;

namespace WebBlog.Models.BlogViewModels
{
    public class CreateViewModel
    {
        [Required, Display(Name = "Header Image")]
        public IFormFile BlogHeaderImage { get; set; }
        public Blog Blog { get; set; }
    }
}

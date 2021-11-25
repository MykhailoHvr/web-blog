using Microsoft.AspNetCore.Mvc;
using WebBlog.BusinessManager.Interfaces;

namespace WebBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostBusinessManager postBusinessManager;

        public HomeController(IPostBusinessManager blogBusinessManager)
        {
            this.postBusinessManager = blogBusinessManager;
        }

        public IActionResult Index(string searchString, int? page)
        {
            return View(postBusinessManager.GetIndexViewModel(searchString, page));
        
        }
    }
}

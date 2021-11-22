using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebBlog.BusinessManager.Interfaces;
using WebBlog.Models.BlogViewModels;

namespace WebBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogBusinessManager blogBusinessManager;
        public BlogController(IBlogBusinessManager blogBusinessManager)
        {
            this.blogBusinessManager = blogBusinessManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View(new CreateViewModel());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var actionResult = await blogBusinessManager.GetEditViewModel(id, User);

            if (actionResult.Result is null)
            {
                return View(actionResult.Value);
            }

            return actionResult.Result;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateViewModel createViewModel)
        {
            await blogBusinessManager.CreateBlog(createViewModel, User);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Update(EditViewModel editBlogViewModel)
        {
            var actionResult = await blogBusinessManager.UpdateBlog(editBlogViewModel, User);

            if (actionResult.Result is null)
            {
                return RedirectToAction("Edit", new { editBlogViewModel.Blog.Id });
            }

            return actionResult.Result;
        }
    }
}

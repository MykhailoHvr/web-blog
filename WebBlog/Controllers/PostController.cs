﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebBlog.BusinessManager.Interfaces;
using WebBlog.Models.PostViewModels;

namespace WebBlog.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostBusinessManager postBusinessManager;
        public PostController(IPostBusinessManager postBusinessManager)
        {
            this.postBusinessManager = postBusinessManager;
        }

        //[Route("Post/{id}"), AllowAnonymous]
        [AllowAnonymous]
        public async Task<IActionResult> Index(int? id)
        {
            var actionResult = await postBusinessManager.GetPostViewModel(id, User);

            if (actionResult.Result is null)
            {
                return View(actionResult.Value);
            }

            return actionResult.Result;
        }

        public IActionResult Create()
        {
            return View(new CreateViewModel());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var actionResult = await postBusinessManager.GetEditViewModel(id, User);

            if (actionResult.Result is null)
            {
                return View(actionResult.Value);
            }

            return actionResult.Result;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateViewModel createViewModel)
        {
            await postBusinessManager.CreatePost(createViewModel, User);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Update(EditViewModel editBlogViewModel)
        {
            var actionResult = await postBusinessManager.UpdatePost(editBlogViewModel, User);

            if (actionResult.Result is null)
            {
                return RedirectToAction("Edit", new { editBlogViewModel.Post.Id });
            }

            return actionResult.Result;
        }
    }
}

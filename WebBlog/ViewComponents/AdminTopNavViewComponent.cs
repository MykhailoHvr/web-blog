﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebBlog.ViewComponents
{
    public class AdminTopNavViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.Factory.StartNew(() => { return View(); });
        }
    }
}

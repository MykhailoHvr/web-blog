using Microsoft.AspNetCore.Mvc;
using WebBlog.Models.HomeViewModels;

namespace WebBlog.BusinessManager.Interfaces
{
    public interface IHomeBusinessManager
    {
        ActionResult<AuthorViewModel> GetAuthorViewModel(string authorId, string searchString, int? page);
    }
}

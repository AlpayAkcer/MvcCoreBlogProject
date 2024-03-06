using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;

namespace MvcCoreBlogProject.Web.ViewComponents.DefaultComponents
{
    public class _DefaultLastBlogCommentPopupTwoListComponent : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _DefaultLastBlogCommentPopupTwoListComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _blogService.TGetLastBlogByPopupTwoList();
            return View(list);
        }
    }
}

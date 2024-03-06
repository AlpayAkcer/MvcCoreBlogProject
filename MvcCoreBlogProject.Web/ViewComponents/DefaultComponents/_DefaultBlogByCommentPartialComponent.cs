using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;

namespace MvcCoreBlogProject.Web.ViewComponents.DefaultComponents
{
    public class _DefaultBlogByCommentPartialComponent : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _DefaultBlogByCommentPartialComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _blogService.TGetBlogByCommentList();
            return View(value);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.BusinessLayer.Concrete;

namespace MvcCoreBlogProject.Web.ViewComponents.DefaultComponents
{
    public class _DefaultLastBlogPartialComponent : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _DefaultLastBlogPartialComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _blogService.TGetLastBlogByList();
            return View(list);
        }
    }
}

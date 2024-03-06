using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;

namespace MvcCoreBlogProject.Web.ViewComponents.DefaultComponents
{
    public class _DefaultFeaturedBlogPartialComponent : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _DefaultFeaturedBlogPartialComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _blogService.TGetCategoryByFeaturedList();
            return View(list);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;

namespace MvcCoreBlogProject.Web.ViewComponents.DefaultComponents
{
    public class _DefaultCommentByBlogPartialComponent : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _DefaultCommentByBlogPartialComponent(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _commentService.TGetCommentsByBlogList(id).ToList();
            return View(value);
        }
    }
}

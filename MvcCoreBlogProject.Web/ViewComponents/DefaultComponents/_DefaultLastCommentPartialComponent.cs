using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Abstract;

namespace MvcCoreBlogProject.Web.ViewComponents.DefaultComponents
{
    public class _DefaultLastCommentPartialComponent : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _DefaultLastCommentPartialComponent(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _commentService.TGetListAll().Take(3).ToList();
            return View(list);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;

namespace MvcCoreBlogProject.Web.ViewComponents.AuthorComponents
{
    public class _AuthorSidebarPartialComponent : ViewComponent
    {
        private readonly IAuthorService _authorService;

        public _AuthorSidebarPartialComponent(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public IViewComponentResult Invoke()
        {
            var user = _authorService.TGetListAll().Where(x => x.Mail == User.Identity.Name).FirstOrDefault();
            ViewBag.username = user.Name + " " + user.Surname;
            ViewBag.AuthorBlogCount = _authorService.TGetAuthorByBlogCount(user.AuthorID);
            return View();
        }
    }
}

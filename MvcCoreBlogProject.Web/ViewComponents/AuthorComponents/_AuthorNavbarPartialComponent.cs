using Microsoft.AspNetCore.Mvc;

namespace MvcCoreBlogProject.Web.ViewComponents.AuthorComponents
{
    public class _AuthorNavbarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MvcCoreBlogProject.Web.ViewComponents.AuthorComponents
{
    public class _AuthorNotificationPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

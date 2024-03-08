using Microsoft.AspNetCore.Mvc;

namespace MvcCoreBlogProject.Web.ViewComponents.AuthorComponents
{
    public class _AuthorMessagePartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

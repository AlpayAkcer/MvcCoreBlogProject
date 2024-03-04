using Microsoft.AspNetCore.Mvc;

namespace MvcCoreBlogProject.Web.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

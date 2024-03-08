using Microsoft.AspNetCore.Mvc;

namespace MvcCoreBlogProject.Web.ViewComponents.DashboardComponents
{
    public class _DashboardSidebarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

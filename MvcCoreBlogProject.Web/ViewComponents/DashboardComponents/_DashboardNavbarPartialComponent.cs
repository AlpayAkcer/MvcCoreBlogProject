using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;

namespace MvcCoreBlogProject.Web.ViewComponents.DashboardComponents
{
    public class _DashboardNavbarPartialComponent : ViewComponent
    {        
        public IViewComponentResult Invoke()
        {          
            return View();
        }
    }
}

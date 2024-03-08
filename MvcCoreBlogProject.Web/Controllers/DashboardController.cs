using Microsoft.AspNetCore.Mvc;

namespace MvcCoreBlogProject.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

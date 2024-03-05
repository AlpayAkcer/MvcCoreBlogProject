using Microsoft.AspNetCore.Mvc;

namespace MvcCoreBlogProject.Web.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

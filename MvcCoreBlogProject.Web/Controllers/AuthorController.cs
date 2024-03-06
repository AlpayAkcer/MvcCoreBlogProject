using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreBlogProject.Web.Controllers
{
    public class AuthorController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AuthorProfile()
        {
            return View();
        }

        public IActionResult AuthorMail()
        {
            return View();
        }
    }
}

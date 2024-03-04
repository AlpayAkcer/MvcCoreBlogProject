using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.Web.Models;
using System.Diagnostics;

namespace MvcCoreBlogProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var value = _categoryService.TGetListAll();
            ViewBag.CategoryCount = _categoryService.TCategoryByCount();
            return View(value);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

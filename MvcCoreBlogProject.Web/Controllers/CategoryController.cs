using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.BusinessLayer.ValidationRules;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.Web.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var list = _categoryService.TGetListAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidation = new CategoryValidator();
            ValidationResult result = categoryValidation.Validate(category);
            if (result.IsValid)
            {
                category.IsStatus = true;
                _categoryService.TAdd(category);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            CategoryValidator categoryValidation = new CategoryValidator();
            ValidationResult result = categoryValidation.Validate(category);
            if (result.IsValid)
            {
                category.IsStatus = true;
                _categoryService.TUpdate(category);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(category);
        }
    }
}

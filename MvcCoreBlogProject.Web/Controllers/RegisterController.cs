using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.BusinessLayer.Concrete;
using MvcCoreBlogProject.BusinessLayer.ValidationRules;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IAuthorService _authorService;

        public RegisterController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Author author)
        {
            AuthorValidator aw = new AuthorValidator();
            ValidationResult validationResult = aw.Validate(author);
            if (validationResult.IsValid) //IsValid eğer bu veriler geçerli ise
            {
                author.Description = "Yazar hakkında";
                author.IsStatus = true;

                _authorService.TAdd(author);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}

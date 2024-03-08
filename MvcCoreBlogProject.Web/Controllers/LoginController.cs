using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.EntityLayer.Concrete;
using System.Security.Claims;

namespace MvcCoreBlogProject.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthorService _authorService;

        public LoginController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.Identity!.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Author author)
        {
            var value = _authorService.TGetListAll().FirstOrDefault(x => x.Mail == author.Mail && x.Password == author.Password);
            if (value != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,author.Mail)
                };
                var userIdentity = new ClaimsIdentity(claims, "A");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Author");
            }
            else
            {
                return View();
            }
        }
    }
}

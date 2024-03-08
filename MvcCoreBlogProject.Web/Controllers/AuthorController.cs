using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.BusinessLayer.ValidationRules;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthorService _authorService;
        public AuthorController(IBlogService blogService, ICategoryService categoryService, IAuthorService authorService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            var user = _authorService.TGetListAll().Where(x => x.Mail == User.Identity.Name).FirstOrDefault();
            int value = _blogService.TGetListAll().Where(x => x.AuthorID == user.AuthorID).Count();
            ViewBag.AuthorBlogCount = value.ToString();
            return View();
        }

        public PartialViewResult Navbar()
        {
            return PartialView();
        }

        // Yazarın Blog sayfaları
        [HttpGet]
        public IActionResult AddBlog()
        {
            var kategori = (from x in _categoryService.TGetListAll().Where(x => x.IsStatus == true)
                            select new SelectListItem
                            {
                                Value = x.CategoryID.ToString(),
                                Text = x.Name
                            }).ToList();
            ViewBag.Category = kategori;

            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            BlogValidator aw = new BlogValidator();
            ValidationResult validationResult = aw.Validate(blog);

            #region DigerKullanımı
            //var kategori = (from x in _categoryService.TGetListAll().Where(x => x.IsStatus == true)
            //                select new SelectListItem
            //                {
            //                    Value = x.CategoryID.ToString(),
            //                    Text = x.Name
            //                }).ToList(); 
            #endregion
            var user = _authorService.TGetListAll().Where(x => x.Mail == User.Identity.Name).FirstOrDefault();
            List<SelectListItem> values = (from x in _categoryService.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.Category = values;



            if (validationResult.IsValid) //IsValid eğer bu veriler geçerli ise
            {
                blog.TopViewCount = 1;
                blog.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.IsStatus = true;
                blog.AuthorID = user.AuthorID;
                _blogService.TAdd(blog);
                return RedirectToAction("Index", "Author");
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

        public IActionResult BlogList()
        {
            var user = _authorService.TGetListAll().Where(x => x.Mail == User.Identity.Name).FirstOrDefault();
            var list = _blogService.TGetBlogByAuthor(user.AuthorID);
            return View(list);
        }

        public IActionResult DeleteBlog(int id)
        {
            var list = _blogService.TGetByID(id);
            _blogService.TDelete(list);
            return RedirectToAction("BlogList", "Author");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var value = _blogService.TGetByID(id);
            List<SelectListItem> values = (from x in _categoryService.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.Category = values;

            return View(value);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            var user = _authorService.TGetListAll().Where(x => x.Mail == User.Identity.Name).FirstOrDefault();
            List<SelectListItem> values = (from x in _categoryService.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.Category = values;
            blog.AuthorID = user.AuthorID;
            blog.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.IsStatus = true;
            _blogService.TUpdate(blog);

            return RedirectToAction("BlogList", "Author");
        }
    }
}

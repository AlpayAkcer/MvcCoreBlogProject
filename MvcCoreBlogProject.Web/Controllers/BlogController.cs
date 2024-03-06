using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.BusinessLayer.Concrete;
using MvcCoreBlogProject.EntityLayer.Concrete;
using MvcCoreBlogProject.Web.Dto.BlogDto;
using X.PagedList;

namespace MvcCoreBlogProject.Web.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthorService _authorService;

        public BlogController(IBlogService blogService, ICategoryService categoryService, IAuthorService authorService)
        {
            _blogService = blogService;
            _authorService = authorService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_blogService.TGetBlogByCategoryList());
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var list = _blogService.TGetByID(id);
            var user = _authorService.TGetByID(list.AuthorID);

            ViewBag.authorName = user.Name + " " + user.Surname;
            ViewBag.authorId = user.AuthorID;
            if (list != null)
            {
                _blogService.TTotalViewCount(id);
                return View(list);
            }
            return View();
        }

        [HttpGet]
        [Route("Kategori/{id}")]
        public IActionResult CategoryByBlogList(int id, int sayfa = 1)
        {
            var list = _blogService.TGetCategoryByBlogList(id);
            var value = _categoryService.TGetByID(id);
            ViewBag.CategoryName = value.Name;
            return View(list.ToPagedList(sayfa, 6));
        }


        [HttpGet]
        [Route("AuthorByBlogPage/{id}")]
        public IActionResult AuthorPageByBlog(int id, int sayfa = 1)
        {
            var user = _authorService.TGetByID(id);
            var value = _blogService.TGetBlogByAuthor(id);
            ViewBag.Authorname = user.Name + " " + user.Surname.ToString();
            ViewBag.Description = user.Description;
            ViewBag.Mail = user.Mail;

            return View(value.ToPagedList(sayfa, 9));
        }
        //_AuthorBlogListPartialComponent
    }
}

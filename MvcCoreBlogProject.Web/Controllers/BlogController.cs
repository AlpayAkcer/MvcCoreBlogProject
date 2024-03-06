﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.BusinessLayer.Concrete;
using MvcCoreBlogProject.EntityLayer.Concrete;
using MvcCoreBlogProject.Web.Dto.BlogDto;
using X.PagedList;

namespace MvcCoreBlogProject.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;

        public BlogController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
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
    }
}

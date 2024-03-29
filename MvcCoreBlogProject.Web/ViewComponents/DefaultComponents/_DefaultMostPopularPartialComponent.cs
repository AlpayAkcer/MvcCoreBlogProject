﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;

namespace MvcCoreBlogProject.Web.ViewComponents.DefaultComponents
{
    public class _DefaultMostPopularPartialComponent : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _DefaultMostPopularPartialComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _blogService.TGetMostPopularBlogList();
            return View(list);
        }
    }
}

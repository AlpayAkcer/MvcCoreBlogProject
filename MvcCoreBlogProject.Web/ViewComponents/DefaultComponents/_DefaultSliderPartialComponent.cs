﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;

namespace MvcCoreBlogProject.Web.ViewComponents.DefaultComponents
{
    public class _DefaultSliderPartialComponent : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _DefaultSliderPartialComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _blogService.TGetBlogByCategoryList();
            return View(list);
        }
    }
}

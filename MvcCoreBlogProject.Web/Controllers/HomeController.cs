﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.Web.Models;
using System.Diagnostics;

namespace MvcCoreBlogProject.Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}

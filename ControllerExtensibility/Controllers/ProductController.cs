﻿using ControllerExtensibility.Models;

using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ViewResult Index()
        {
            return View("Result", new Result()
            {
                ControllerName = "Product",
                ActionName = "Index",
            });
        }

        [Route("Demo")]
        public ViewResult List()
        {
            return View("Result", new Result()
            {
                ControllerName = "Product",
                ActionName = "List",
            });
        }
    }
}
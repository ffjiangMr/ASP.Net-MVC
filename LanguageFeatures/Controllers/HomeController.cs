using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LanguageFeatures.Models;
using System.Web.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index()
        {
            return "Navigate to a URL to show an example";
        }

        public ViewResult AutoProperty()
        {
            Product myProduct = new Product();
            myProduct.Name = "Kayak";
            String productName = myProduct.Name;
            return View("Result", (Object)$"Product name: {productName}");
        }
    }
}
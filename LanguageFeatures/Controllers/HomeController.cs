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

        public ViewResult CreateProduct()
        {
            Product myProduct = new Product();
            myProduct.Name = "Kayak";
            myProduct.Price = 275M;
            myProduct.ProductID = 100;
            myProduct.Description = "A boat for one person";
            myProduct.Category = "Watersports";
            return View("Result", (Object)$"Category:{myProduct.Category}");
        }

        public ViewResult CreateCollection()
        {
            String[] stringArray = { "apple", "orange", "plum" };
            List<Int32> intList = new List<Int32> { 10, 20, 30, 40 };
            Dictionary<String, Int32> myDict = new Dictionary<String, Int32>
            {
                { "apple",10},{ "orange",20},{ "plum",30}
            };
            return View("Result", (Object)stringArray[1]);
        }
    }
}
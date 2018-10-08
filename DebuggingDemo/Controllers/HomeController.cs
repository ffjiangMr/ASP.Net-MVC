using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DebuggingDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Int32 firstVal = 10;
            Int32 secondVal = 5;
            Int32 result = firstVal / secondVal;
            ViewBag.Message = "Welcome to asp.net mvc!";            
            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
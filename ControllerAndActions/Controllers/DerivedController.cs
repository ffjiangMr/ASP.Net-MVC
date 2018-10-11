using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ViewResult Index()
        {
            this.ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
        }
    }
}
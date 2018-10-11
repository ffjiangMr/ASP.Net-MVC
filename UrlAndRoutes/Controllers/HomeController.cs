using System.Web.Mvc;
using System;

namespace UrlAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult CustomVariable()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariable";
            ViewBag.CustomVariable = RouteData.Values["id"];
            return View("ActionName");
        }

        public ViewResult MyActionMethod()
        {
            String myActionUrl = Url.Action("Index", new { id = "myID" });
            String routeUrl = Url.RouteUrl(new { controller = "Home", action = "Index" });
            return View();
        }

    }
}
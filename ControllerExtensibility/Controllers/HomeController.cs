using ControllerExtensibility.Infrastructure;
using ControllerExtensibility.Models;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result()
            {
                ControllerName = "Home",
                ActionName = "LocalIndex",
            });
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
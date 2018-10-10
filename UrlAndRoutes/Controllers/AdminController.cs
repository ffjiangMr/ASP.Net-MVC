using System.Web.Mvc;

namespace UrlAndRoutes.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Controller = "Admin";
            ViewBag.Action = "Inmdex";
            return View("ActionName");
        }
    }
}
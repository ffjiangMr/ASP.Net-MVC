using System.Web.Mvc;

namespace UrlAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult List()
        {
            ViewBag.Contorller = "Customer";
            ViewBag.Action = "List";
            return View("ActionName");
        }
    }
}
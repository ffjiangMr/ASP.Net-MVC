using System.Web.Mvc;

namespace UrlAndRoutes.Controllers
{
    //[RouteArea("Services")]
    public class CustomerController : Controller
    {
        // GET: Customer      
        [Route("test")]
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
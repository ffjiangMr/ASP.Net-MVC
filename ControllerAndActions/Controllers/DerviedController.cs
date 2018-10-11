using System.Web.Mvc;

namespace ControllerAndActions.Controllers
{
    public class DerviedController : Controller
    {
        public ActionResult Index()
        {
            this.ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
        }
    }
}
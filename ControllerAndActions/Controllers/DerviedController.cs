using ControllerAndActions.Infrastructure;
using System.Web.Mvc;

namespace ControllerAndActions.Controllers
{
    public class DerviedController : Controller
    {
        public ViewResult Index()
        {
            this.ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
        }

        public ActionResult ProduceOutput()
        {
            if (Server.MachineName == "TINY")
            {
                return new CustomRedirectResult() { Url = "/Basic/Index" };
            }
            else
            {
                Response.Write("Controller:Dervied,Action:ProduceOutput");
            }
            return null;
        }

    }
}
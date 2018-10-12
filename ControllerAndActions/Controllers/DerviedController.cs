using ControllerAndActions.Infrastructure;
using System;
using System.IO;
using System.Text;
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

        public FileResult FileAction()
        {
            using (StreamReader reader = new StreamReader(@"d:\123", Encoding.UTF8))
            {
                var temp = reader.ReadToEnd();
                var buffer = Encoding.UTF8.GetBytes(temp);
                return File(buffer, "text/plain; charset=utf-8");
            }
        }

    }
}
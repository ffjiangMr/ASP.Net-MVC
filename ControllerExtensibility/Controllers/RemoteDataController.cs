using ControllerExtensibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class RemoteDataController : Controller
    {

        public ActionResult Data()
        {
            RemoteService service = new RemoteService();
            String data = service.GetRemotrData();
            return View((Object)data);
        }

    }
}
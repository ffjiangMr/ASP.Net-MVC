using System;
using System.Web.Mvc;

namespace UrlAndRoutes.Controllers
{
    public class LegacyController : Controller
    {

        public ActionResult GetLegacyURL(String legacyURL)
        {
            return View((Object)legacyURL);
        }

    }
}
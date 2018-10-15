using System;
using System.Web.Mvc;

namespace Filters.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        public String Index()
        {
            return "This is the Index action on the home controller";
        }

    }
}
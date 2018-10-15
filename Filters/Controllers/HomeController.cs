using Filters.Infrastructure;

using System;
using System.Web.Mvc;

namespace Filters.Controllers
{
    [CustomAuth(false)]
    public class HomeController : Controller
    {

        public String Index()
        {
            return "This is the Index action on the home controller";
        }

    }
}
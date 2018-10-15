using Filters.Infrastructure;

using System;
using System.Web.Mvc;

namespace Filters.Controllers
{

    public class HomeController : Controller
    {

        [CustomAuth(true)]
        public String Index()
        {
            return "This is the Index action on the home controller";
        }

        //[GoogleAuth]
        [CustomAuth(true)]
        public String List()
        {            
            return "This is the List action on the Home controller";
        }

    }
}
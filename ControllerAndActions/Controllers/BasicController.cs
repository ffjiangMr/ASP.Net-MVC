using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllerAndActions.Controllers
{
    public class BasicController : IController
    {
        public void Execute(RequestContext requestContext)
        {            
            String controller = (String)requestContext.RouteData.Values["controller"];
            String action = (String)requestContext.RouteData.Values["action"];
            requestContext.HttpContext.Response.Write("controller: " + controller + Environment.NewLine + "action: " + action + Environment.NewLine);
        }
    }
}
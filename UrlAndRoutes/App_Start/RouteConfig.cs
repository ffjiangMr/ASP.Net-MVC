using System.Web.Mvc;
using System.Web.Routing;
using UrlAndRoutes.Infrastructure;

namespace UrlAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.RouteExistingFiles = true;
            routes.MapMvcAttributeRoutes();
            routes.IgnoreRoute("Content/{filename}.html");
            routes.Add(new LegacyRoute("~/articles/Windows_3.1.Overview.html", "~/old/.NET.1.0_Class_Library"));
            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.MapRoute(
            //    name: "MyRoute",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            //);
            routes.MapRoute("MyRoute", "{controller}/{action}", namespaces: new[] { "UrlAndRoutes.Controllers" });
            //routes.MapRoute("MyOtherRoute", "App/{controller}/{action}", new { controller = "Home" });

            //routes.Add("MyRoute", weosha myRoute);
        }
    }
}

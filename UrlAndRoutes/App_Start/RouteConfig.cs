using System.Web.Mvc;
using System.Web.Routing;

namespace UrlAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            routes.MapRoute(
                name: "MyRoute",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                
            );
            //routes.Add("MyRoute", weosha myRoute);
        }
    }    
}

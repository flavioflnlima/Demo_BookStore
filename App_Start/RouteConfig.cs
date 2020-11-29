using System.Web.Mvc;
using System.Web.Routing;

namespace BookStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.maproute(
            //    name: "default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "home", action = "index", id = urlparameter.optional }
            //);
        }
    }
}

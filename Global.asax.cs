using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace InventoryManagement
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.MapRoute("Default",
                "{controller}/{action}/{id}",
                new { controller = "Product", action = "Index",
                    id = UrlParameter.Optional });
        }
    }
}

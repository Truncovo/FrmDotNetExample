using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace FrmDotNetExample
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();

            config.Routes.MapHttpRoute(
                "Reports",
                "api/{value}",
                new { controller = "AppApi" ,action="Generic"}
                
            );
        }
    }
}
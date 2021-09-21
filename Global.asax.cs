using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Net.Http;

namespace TesteConsumoAPIsZX
{
    public class Global : HttpApplication
    {
        HttpClient client;
        Uri usuarioUri;

        void Application_Start(object sender, EventArgs e)
        {

            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:1020");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }

            // Code that runs on application startup
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
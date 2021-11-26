using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebAPIOwinBoilerplate
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // This is the default entry point to any new Web API project.

            // This entry point can be replaced by the OWIN Startup.cs class.  The Configuration method (which is required by the Microsoft.Owin.Host.SystemWeb package)
            // is where WebApi configuration is stored (i.e. WebApiConfig.Register).

            // This Application_Start() method has been left here for the purposes of demonstrating the default entry point for Web Api application which 
            // can be replaced or co-exist with Startup.cs.  

            //GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}

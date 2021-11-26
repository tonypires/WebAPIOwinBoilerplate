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
            // When creating a new Web API project this is the default entry point to your API.  Using OWIN / Katana
            // as middleware

            // This entry point is replaced by the OWIN Startup.cs class.  The Configuration method (which is required)
            // is where any WebApi configuration is placed (i.e. WebApiConfig.Register).  
            // Leaving this Application_Start() method here will result in it running along with the OWIN entry point.  
            // Better to remove it so there's only one entry point (OWIN Startup.cs).  However, leaving it here for learning purposes.

            //GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}

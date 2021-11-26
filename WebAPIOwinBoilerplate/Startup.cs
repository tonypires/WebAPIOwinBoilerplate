using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPIOwinBoilerplate
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            appBuilder.UseWebApi(config);
        }
    }
}
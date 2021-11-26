using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIOwinBoilerplate;

namespace WebAPIOwinSelfHosted
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://localhost:8100";

            Console.WriteLine("Starting the self-hosted web api using OWIN...");

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Web Api server running at {0} - press Enter to quit.", baseAddress);
                Console.ReadLine();
            }
        }
    }
}

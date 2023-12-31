﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHostServer.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cfg = new HttpSelfHostConfiguration("http://localhost:8080");
            cfg.Routes.MapHttpRoute("Default", "api/{controller}/{id}", new { id = RouteParameter.Optional });
            HttpSelfHostServer server = new HttpSelfHostServer(cfg);
            server.OpenAsync().Wait();
            Console.ReadLine();
        }
    }
}

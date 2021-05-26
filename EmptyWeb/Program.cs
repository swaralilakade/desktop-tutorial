using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EmptyWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create Host 
            //Create HTTP Server
            //Build HTTP Server
            //Run HTTP Server
            //-------------Keep HTTP SErver listening on port
            //-------------for incomming HTTP requests from client Apps
            
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

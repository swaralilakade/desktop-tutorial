using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;

namespace TransflowerStoreWeb.Controllers
{

    //it is a special kind of Class
    //it is responsibile for procssing inomming HTTP requests
    //it is responsibile for generating outgoing HTTP response

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            // it sends view which has presentation
        }
        public IActionResult AboutUs(){

            return View();
        }

        public IActionResult List()
        {
            return View();
            
        }
        public IActionResult Contact(){

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

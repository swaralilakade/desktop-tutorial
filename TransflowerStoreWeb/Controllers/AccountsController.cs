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
    public class AccountsController : Controller
    {
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
            
        }

        public IActionResult Logout()
        {
            return View();
            
        }
        public IActionResult Register()
        {
            return View();
           
        }

        public IActionResult ForgotPassword( )
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

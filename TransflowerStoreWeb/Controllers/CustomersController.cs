using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using CRM;

namespace TransflowerStoreWeb.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;
        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        //Each URL request is mapped with action method
        //request type : GET
        public IActionResult Index()
        {
           List<Customer> allCustomers= CRM.CustomerManager.GetAll();
           // this data we call it as Model
           // viewData is member of controller instance 
           // used to transfer model from controller action method to it's respective
           this.ViewData["customers"]=allCustomers;
            return View();  
        }
 
         public ActionResult Details(int customerId)
        {
            Customer customers = CustomerManager.GetById(customerId);
            this.ViewData["customer"]=customers;
            return View();
            //detais.cshtml file----razor--------views
        }

        public ActionResult Delete(int id)
        {
        
            CustomerManager.Delete(id);

            //redirection main list using inbuilt method providedby controller
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

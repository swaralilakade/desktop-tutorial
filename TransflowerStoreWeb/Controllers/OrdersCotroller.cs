using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using OrderProcessing;

namespace TransflowerStoreWeb.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ILogger<OrdersController> _logger;
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        //Each URL request is mapped with action method
        //request type : GET
        public IActionResult Index()
        {
           List<Order> allOrders= OrderProcessing.OrderManager.GetAll();
           // this data we call it as Model
           // viewData is member of controller instance 
           // used to transfer model from controller action method to it's respective
           this.ViewData["orders"]=allOrders;
            return View();  
        }
 
         public ActionResult Details(int id)
        {
            Order Order = OrderManager.GetById(id);
            this.ViewData["order"]=Order;
            return View();
            //detais.cshtml file----razor--------views
        }

        public ActionResult Delete(int id)
        {
           // Product Product = ProductManager.Get(id);
            OrderManager.Delete(id);

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

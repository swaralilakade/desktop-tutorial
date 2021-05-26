using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using Catalog;

namespace TransflowerStoreWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        //Each URL request is mapped with action method
        //request type : GET
        public IActionResult Index()
        {
           List<Product> allProducts= Catalog.ProductManager.GetAllProducts();
           // this data we call it as Model
           // viewData is member of controller instance 
           // used to transfer model from controller action method to it's respective
           this.ViewData["products"]=allProducts;
            return View();  
        }
 
         public ActionResult Details(int id)
        {
            Product Product = ProductManager.Get(id);
            this.ViewData["product"]=Product;
            return View();
            //detais.cshtml file----razor--------views
        }

        public ActionResult Delete(int id)
        {
           // Product Product = ProductManager.Get(id);
           // ProductManager.Delete(id);

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

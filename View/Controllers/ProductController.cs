using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Logic.Interfaces;


namespace View.Controllers
{
    public class ProductController : Controller
    {
        public ProductController(IProductDAO productDatabaseManager, IReviewDAO reviewDatabaseManager, IBidDAO bidDatabaseManager)
        {
            
        }

        // GET: ProductController
        //public IActionResult _ViewProduct(int id)
        //{
        //    var product = new RegularProduct(1, "cocl", 1);
        //    return View(product);
        //}

      
        
    }
}

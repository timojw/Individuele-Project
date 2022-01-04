using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Logic;

namespace View.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public IActionResult _ViewProduct(int id)
        {
            var product = new RegularProduct() { name = "coc" };
            return View(product);
        }

      
        
    }
}

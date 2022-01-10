using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Logic.Interfaces;
using View.Models;
using Logic.Managers;
using Logic.Classes;

namespace View.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager;
        public ProductController(IProductDAO productDatabaseManager, IReviewDAO reviewDatabaseManager, IBidDAO bidDatabaseManager)
        {
            this.productManager = new ProductManager(productDatabaseManager, reviewDatabaseManager, bidDatabaseManager);
        }

         //GET: ProductController
        public IActionResult Index(int id)
        {
            var product = productManager.GetProduct(id);
            var model = new ProductViewModel()
            { 
                Name = product.Name,
                Description = product.Descripion,
                //Price = product.Price,
                Available = product.Available,
                UserID = product.UserID
            };
            
            return View(model);
        }

        public IActionResult Create()
        {
            Product product = new Product();
            return View();
        }

      
        
    }
}

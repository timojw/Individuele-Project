using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using View.Models;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity;
using Logic;

namespace View.Controllers
{
    public class HomeController : Controller       
    {
        UserM2anager userManager;
        ProductManager productManager;   
        public HomeController(IProductDAO iproductDAO, IUserDAO iuserDAO, IReviewDAO ireviewDAO, IBidDAO ibidDAO)
        {
            userManager = new UserM2anager(iuserDAO, iproductDAO, ireviewDAO, ibidDAO);
            
        }

        public IActionResult Index()
        {
            List<ProductViewModel> models = new();
            foreach (var product in productManager.GetAllProducts())
            {
                if (product.Available > 0 && models.Count < 7)
                {
                    models.Add(new ProductViewModel()
                    {
                        ID = product.ID,
                        Name = product.Name,
                        UserID = product.UserID,
                        //Bids 
                        
                    });
                }
            }
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

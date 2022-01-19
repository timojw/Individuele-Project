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
using Logic.Classes;

namespace View.Controllers
{
    public class HomeController : Controller       
    {
        UserManager userManager;
        ProductManager productManager;   
        public HomeController(IProductDAO iproductDAO, IUserDAO iuserDAO, IReviewDAO ireviewDAO, IBidDAO ibidDAO)
        {
            userManager = new UserManager(iuserDAO, iproductDAO, ireviewDAO, ibidDAO);
            productManager = new ProductManager(iproductDAO, ireviewDAO, ibidDAO);

        }

        public IActionResult Index()
        {
            List<ProductViewModel> models = new();
            List<Product> products = new List<Product>();
            products = productManager.GetAllProducts();
            products.Reverse();
            foreach (var product in products)
            {
                if (models.Count < 6)
                {
                    ProductViewModel model = new ProductViewModel();   
                    {
                        model.ID = product.ID;
                        model.Name = product.Name;
                        model.UserID = product.UserID;
                        model.Available = product.Available;
                        model.Description = product.Descripion;
                        
                        //model.Price = product.Price;
                    }
                    model.Reviews = new List<ReviewViewModel>();
                    foreach (var review in productManager.GetAllReviews(product))
                    { 
                        if (model.Reviews != null)
                        {
                            ReviewViewModel review1 = new ReviewViewModel();
                            {
                                review1.Id = review.ID;
                                review1.Stars = review.Stars;
                                review1.Text = review.Text;
                                review1.ReviewerID = review.ReviewerID;
                                review1.ProductID = product.ID;
                                review1.ReviewerName = userManager.GetUserByID(review.ReviewerID).Name;
                            }
                        model.Reviews.Add(review1);
                        }
                    }
                    models.Add(model);                            
                }
            }
            
            return View(models);
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

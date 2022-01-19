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
        UserManager userManager;
        ProductManager productManager;
        public ProductController(ProductManager _productManager, UserManager _userManager)
        {
            userManager = _userManager;
            productManager = _productManager;

        }
        public IActionResult Index(int id)
        {
            var product = productManager.GetProduct(id);
            var model = new ProductViewModel()
            {
                ID = product.ID,
                Name = product.Name,
                Description = product.Descripion,
                //Price = product.Price,
                Available = product.Available,
                UserID = product.UserID,
                UserName = userManager.GetUserByID(product.UserID).Name,
                Reviews = new List<ReviewViewModel>()
            };
            foreach (var review in productManager.GetAllReviews(product))
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
            return View(model);
        }

        public IActionResult Create()
        {            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] ProductViewModel viewModel)
        {
            try
            {
                productManager.AddProduct(new Product() { Name = viewModel.Name, Descripion = viewModel.Description, Available = viewModel.Available, Price = viewModel.Price, UserID = 1, Deadline = DateTime.Now.AddDays(-1000) });
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public IActionResult AddReview(int id)
        {
            var product = productManager.GetProduct(id);
            var user = userManager.GetUser();
            ReviewViewModel model = new ReviewViewModel()
            {
                ProductID = id,
                ReviewerID = user.ID,
                ReviewerName = user.Name
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddReview([FromForm] ReviewViewModel viewModel)
        {
            try
            {
                productManager.AddReview(new Logic.ProductReview(viewModel.ReviewerID, viewModel.ProductID, viewModel.Text, viewModel.Stars));
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}

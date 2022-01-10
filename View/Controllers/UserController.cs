using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Logic.Managers;
using Logic.Interfaces;
using Logic.Classes;
using View.Models;
using Logic;

namespace View.Controllers
{
    public class UserController : Controller
    {
        ProductManager productManager;
        UserManager userManager;
        public UserController(IProductDAO productDatabaseManager, IReviewDAO reviewDatabaseManager, IBidDAO bidDatabaseManager, IUserDAO iuserdao)
        {
            this.productManager = new ProductManager(productDatabaseManager, reviewDatabaseManager, bidDatabaseManager);
            this.userManager = new UserManager(iuserdao, productDatabaseManager, reviewDatabaseManager, bidDatabaseManager);
        }
        public IActionResult Index(int id)
        {
            User user = userManager.GetUserByID(id);
            UserViewModel model = new UserViewModel()
            {
                ID = user.ID,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
            model.Products = productManager.GetProductsByUser(user.ID);
            return View(model);
        }
    }
}

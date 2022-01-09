using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces;

namespace Logic.Managers
{
    class UserManager
    {
        private IUserDAO userDatabaseManager;
        private IProductDAO productDatabaseManager;
        private IReviewDAO reviewDatabaseManager;
        private IBidDAO bidDatabaseManager;
        public UserManager(IUserDAO _userDatabaseManager, IProductDAO _productDatabaseManager, IReviewDAO _reviewDatabaseManager, IBidDAO _bidDatabaseManager)
        {
            this.userDatabaseManager = _userDatabaseManager;
            this.productDatabaseManager = _productDatabaseManager;
            this.reviewDatabaseManager = _reviewDatabaseManager;
            this.bidDatabaseManager = _bidDatabaseManager;
        }
        User MakeUser(string _name, string _email, string _password)
        {

            int ID = userDatabaseManager.AddUser(new DTO.UserDTO()
            {
                Name = _name,
                Email = _email,
                Password = _password,
                RegisterDate = DateTime.Now
            });
            
            User user = new User(_name, _email, _password, productDatabaseManager, reviewDatabaseManager, bidDatabaseManager);
            user.ID = ID;
            return user;
        }

        
    }
}

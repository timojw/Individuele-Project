using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces;

namespace Logic.Managers
{
    public class UserManager
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
        public User MakeUser(string _name, string _email, string _password)
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
        public User GetUser()
        {
            DTO.UserDTO user = userDatabaseManager.GetUserByID(1);
            User user1 = new User(user.Name, user.Email, user.Password, productDatabaseManager, reviewDatabaseManager, bidDatabaseManager) { ID = user.ID};
            return user1;
        }
        public User GetUserByID(int id)
        {
            DTO.UserDTO user1 = userDatabaseManager.GetUserByID(id);
            User user = new User(user1.Name, user1.Email, user1.Password, productDatabaseManager, reviewDatabaseManager, bidDatabaseManager)
            {
                ID = user1.ID,
                RegisterDate = user1.RegisterDate,
                
            };
            return user;
        }
    }
}

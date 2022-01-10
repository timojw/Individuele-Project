using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.DTO;
using DAL.Managers;

namespace Individueel
{
    [TestClass]
    class UserTest
    {
        [TestMethod]
        public void Can_Users_Be_Added_To_DB()
        {
            UserDTO user = new UserDTO()
            {
                Name = "Timo",
                Email = "timomaas25@gmail.com",
                Password = "Password123",
                RegisterDate = DateTime.Now,
                Country = "Netherlands",
                State = "Brabant",
                City = "Bergeijk",
                Street = "Schadewijk",
                HouseNumber = 10,
                PostalCode = "6621"              
            };
            UserDAO dao = new UserDAO();

            dao.AddUser(user);

            Assert.IsTrue(dao.GetAllUsers().Count > 0);
        }
    }
}

//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using DAL;
//using Logic;
//using View;
//using System.Linq;
//using System;

//namespace Individueel
//{
//    [TestClass]
//    public class ProductTest
//    {
//        [TestMethod]
//        public void Product_Can_Be_Added_To_Database()
//        {
//            //Arrange
//            Logic.DTO.ProductDTO productDTO = new Logic.DTO.ProductDTO()
//            {
//                Name = "TestProduct6",
//                Description = "mooinee ding10",
//                UserID = 10,
//                Available = 19,
//                Price = 420,
//                OrderID = 34289,
//                Deadline = DateTime.Now.AddDays(-1000)               
//            };
//            DAL.Managers.ProductDAO dao = new DAL.Managers.ProductDAO();

//            //Act
//            dao.AddProduct(productDTO);

//            //Assert
//            Assert.IsTrue(dao.GetAllProducts().Count() > 0);
//        }
//        [TestMethod]
//        public void Can_Delete_Product_From_Database()
//        {
//            Logic.DTO.ProductDTO productDTO = new Logic.DTO.ProductDTO();
//            productDTO.ID = 11;
//            DAL.Managers.ProductDAO dao = new DAL.Managers.ProductDAO();

//            dao.DeleteProduct(productDTO);

//            Assert.IsTrue(dao.GetAllProducts().Count() < 11);
//        }
//        //[TestMethod]
//        //public void Can_Users_Be_Added_To_DB()
//        //{
//        //    Logic.DTO.UserDTO user = new Logic.DTO.UserDTO()
//        //    {
//        //        Name = "Jan",
//        //        Email = "janjansen@gmail.com",
//        //        Password = "Password12345",
//        //        RegisterDate = DateTime.Now,
//        //        Country = "Netherlands",
//        //        State = "Brabant",
//        //        City = "Eindhoven",
//        //        Street = "Fonyslaan",
//        //        HouseNumber = 17,
//        //        PostalCode = "5545"
//        //    };
//        //    DAL.Managers.UserDAO dao = new DAL.Managers.UserDAO();

//        //    dao.AddUser(user);

//        //    Assert.IsTrue(dao.GetAllUsers().Count > 0);
//        //}
//        //[TestMethod]
//        //public void Can_Delete_Users_From_Database()
//        //{
//        //    Logic.DTO.UserDTO userDTO = new Logic.DTO.UserDTO();
//        //    userDTO.ID = 2;
//        //    DAL.Managers.UserDAO dao = new DAL.Managers.UserDAO();

//        //    dao.DeleteUser(userDTO);

//        //    Assert.IsTrue(dao.GetAllUsers().Count() < 8);
//        //}
//    }
//}

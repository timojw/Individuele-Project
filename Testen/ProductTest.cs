using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Logic;
using View;
using System.Linq;
using System;

namespace Individueel
{
    [TestClass]
    public class ProductTest
    {
        //[TestMethod]
        //public void Product_Can_Be_Added_To_Database()
        //{
        //    // Arrange
        //    Logic.DTO.ProductDTO productDTO = new Logic.DTO.ProductDTO()
        //    {
        //        Name = "TestProduct",
        //        Description = "wouw mooi",
        //        Status = 220,
        //        Available = 5,
        //         Deadline = DateTime.Now.AddDays(-100),
        //        Price = 6,
        //        OrderID = 3428904
        //
        //    };
        //    DAL.Managers.ProductDAO dao = new DAL.Managers.ProductDAO();
        //
        //    // Act
        //   dao.AddProduct(productDTO);
        //
        //    Assert.IsTrue(dao.GetAllProducts().Count() > 0);
        //}
        [TestMethod]
        public void Can_Delete_Product_From_Database()
        {
            Logic.DTO.ProductDTO productDTO = new Logic.DTO.ProductDTO();
            productDTO.ID = 1;
            DAL.Managers.ProductDAO dao = new DAL.Managers.ProductDAO();

            dao.DeleteProduct(productDTO);

            Assert.IsTrue(dao.GetAllProducts().Count() < 11);
        }
    }
}

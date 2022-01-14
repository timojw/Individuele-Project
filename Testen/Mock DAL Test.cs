using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testen;
using Logic.Managers;
using Logic.Classes;

namespace Individueel
{
    [TestClass]
    public class UserTest
    {  
        [TestMethod]
        public void ManagerAddProductTest()
        {
            //ARRANGE
            MockProductDAO mockProductDAO = new MockProductDAO();
            MockReviewDAO mockReviewDAO = new MockReviewDAO();
            MockBidDAO mockBidDAO = new MockBidDAO();
            ProductManager productManager = new ProductManager(mockProductDAO, mockReviewDAO, mockBidDAO);
            Product product = new Product() {
                Name = "Mooie Laptop",
                Descripion = "Nieuw en goed"
            };

            //ACT
            productManager.AddProduct(product);

            //ASSERT
            Assert.AreEqual(product.Name, mockProductDAO.Name);
        }
    }
}

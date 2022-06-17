using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO_Layer;
using System.Collections.Generic;

namespace Testen
{
    [TestClass]
    public class UnitTest1
    {
        public Mockdal mock;
        public UnitTest1()
        {
            mock = new Mockdal();
        }
        [TestMethod]
        public void TestAddOrder()
        {
            //Arrange
            OrderDTO order = new OrderDTO();
            order.RestaurantID = 1;
            order.Deliverer = 1;
            order.Longitude = 22;
            order.Latitude = 22;

            int hoeveel = mock.Orders.Count;
  
            //Act
            mock.AddOrder(order);

            //Assert
            Assert.IsTrue(mock.Orders.Count > hoeveel);
        }
        [TestMethod]
        public void TestDeleteOrder()
        {
            //Arrange
            OrderDTO order = new OrderDTO();
            order.ID = 99;
            int hoeveel = mock.Orders.Count;

            //Act
            mock.DeleteOrder(99);

            //Assert
            Assert.IsTrue(mock.Orders.Count < hoeveel);
        }
        [TestMethod]
        public void TestGetALlOrders()
        {
            //Arrage
            int hoeveel = mock.Orders.Count;

            //Act
            List<OrderDTO> templist = mock.GetAllOrders();

            //Assert
            Assert.IsTrue(hoeveel == templist.Count);
        }
    }
}
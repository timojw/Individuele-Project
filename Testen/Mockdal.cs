using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction_Layer;
using DTO_Layer;

namespace Testen
{
    public class Mockdal : IOrderCreation, IOrderCollection
    {
        public List<OrderDTO> Orders = new List<OrderDTO>();
        public bool AddOrder(OrderDTO orderDTO)
        {
        Orders.Add(orderDTO);
            return true;

        }

        public void DeleteOrder(int ID)
        {
            foreach (OrderDTO order in Orders)
            {
                if (order.ID == ID)
                {
                    Orders.Remove(order);
                    return;
                }
            }
        }

        public List<OrderDTO> GetAllOrders()
        {
            return Orders;  
        }

        public OrderDTO GetOrderByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}

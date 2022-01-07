using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IOrderDatabaseManager
    {
        List<OrderDTO> GetAllOrders();
        void AddOrder(OrderDTO orderDTO);
    }
}
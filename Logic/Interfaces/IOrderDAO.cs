using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IOrderDAO
    {
        List<OrderDTO> GetAllOrders();
        void AddOrder(OrderDTO orderDTO);
    }
}
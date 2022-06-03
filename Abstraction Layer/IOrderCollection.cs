using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Layer;

namespace Abstraction_Layer
{
    public interface IOrderCollection
    {
        public OrderDTO GetOrderByID(int id);
        public List<OrderDTO> GetAllOrders();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Layer;

namespace Abstraction_Layer
{
    public interface IOrderCreation
    {
        public bool AddOrder(OrderDTO orderDTO);
        public void DeleteOrder(int ID);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Layer;

namespace Abstraction_Layer
{
    public interface IDelivererCollection
    {
        public DelivererDTO GetDelivererByID(int id);
        public List<DelivererDTO> GetAllDeliverers();
    }
}

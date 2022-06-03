using Abstraction_Layer;
using DTO_Layer;
using Microsoft.EntityFrameworkCore;

namespace DAL_Layer
{
    public class DelivererDAL : IDelivererCollection, IDelivererCreation
    {
        public DelivererDTO GetDelivererByID(int ID)
        {
            return null;
        }
        public List<DelivererDTO> GetAllDeliverers()
        {
            return null; 
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Layer;

namespace DAL_Layer.Model
{
    public class Order
    {
        public Order()
        {

        }

        public Order(OrderDTO orderDTO)
        {
            ID = orderDTO.ID;
            Deliverer = orderDTO.Deliverer;
            DeliveryTime = orderDTO.DeliveryTime;
            Latitude = orderDTO.Latitude;
            Longitude = orderDTO.Longitude;
            Status = orderDTO.Status;
            RestaurantID = orderDTO.RestaurantID;
        }

        // Primary Key
        public int ID { get; set; }

        // Properties
        public DateTime DeliveryTime { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Status { get; set; }

        // Foreign Keys
        public int Deliverer { get; set; }
        public int RestaurantID { get; set; }

        // Navigational Properties

        // Methods
        public OrderDTO ToDTO()
        {
            return new OrderDTO
            {
                ID = ID,
                Deliverer = Deliverer,
                DeliveryTime = DeliveryTime,
                Latitude = Latitude,
                Longitude = Longitude,
                RestaurantID = RestaurantID
                
            };
        }
    }
}

namespace DTO_Layer
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public int RestaurantID { get; set; }
        public int Deliverer { get; set; }
        public DateTime DeliveryTime { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Status { get; set; }
    }
}

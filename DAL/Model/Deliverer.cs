using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Layer;

namespace DAL_Layer.Model;
public class Deliverer
{
    public Deliverer()
    {

    }
  public Deliverer(DelivererDTO delivererDTO)
    {
        ID = delivererDTO.ID;
        Name = delivererDTO.Name;
        RestaurantID = delivererDTO.RestaurantID;

    }

    // Primary Key
    public int ID { get; set; }

    // Properties
    public string Name { get; set; }

    // Foreign Keys
    public int RestaurantID { get; set; }

    // Navigational Properties

    // Methods
    public DelivererDTO ToDTO()
    {
        return new DelivererDTO
        {
            ID = ID,
            Name = Name,
            RestaurantID = RestaurantID
        };
    }
}
  

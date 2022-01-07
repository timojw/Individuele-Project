using System;
using Logic.Interfaces;

namespace View.Models
{
    public class RegularProduct:Product
    {
        public double Price { get; set; }

        public RegularProduct(int _userID, string _name, int _available)
        {
            this.UserID = _userID;
            this.Name = _name;
            this.Available = _available;
        }
    }
}

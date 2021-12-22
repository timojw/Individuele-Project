using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Product
    {
        public string productID { get; set; }
        public string userID { get; set; }
        public string name { get; set; }
        public int available { get; set; }

        protected string generateProductID(string ProductType)
        {
            Guid tempID = Guid.NewGuid();
            string tempIDString = tempID.ToString();

            return $"{ProductType}-{tempIDString}";

            //string ProductType = tempString.Substring(0, 1);
        }
    }
}

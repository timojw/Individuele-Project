﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Product
    {
        public int productID { get; set; }
        public int userID { get; set; }
        public string name { get; set; }
        public int available { get; set; }

        protected int generateProductID()
        {
            return 1;
        }
    }
}

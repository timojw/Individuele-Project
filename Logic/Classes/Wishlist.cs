﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Logic.Classes
{
    class Wishlist
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }

    }
}

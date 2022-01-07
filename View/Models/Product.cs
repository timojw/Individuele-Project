using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace View.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Available { get; set; }
    }
}

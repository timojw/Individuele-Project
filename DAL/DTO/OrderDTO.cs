using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class OrderDTO
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Status { get; set; }
        public DateTime Time { get; set; }
    }
}

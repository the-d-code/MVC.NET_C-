using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExternalTuition.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int  Qty{ get; set; }

        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
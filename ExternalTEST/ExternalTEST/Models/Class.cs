using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalTEST.Models
{
    public class Class
    {
        public int OrderId { get; set; }
        public string  ProductName { get; set; }
        public string CustomerName { get; set; }
         public DateTime? Date { get; set; }

        public decimal? TotalAmount { get; set; }

        public int? Qty { get; set; }

       
    }
}

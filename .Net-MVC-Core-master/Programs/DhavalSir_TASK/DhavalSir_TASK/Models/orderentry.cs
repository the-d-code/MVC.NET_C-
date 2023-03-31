using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DhavalSir_TASK.Models
{
    public class orderentry
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string Date { get; set; }

        public int TotalAmount { get; set; }

        public int ProductId { get; set; }
      

        public int OrderdetailId { get; set; }
        public int Rate { get; set; }
        public int Qty { get; set; }

        //public List<CustomerTB> cust { get; set; }
        //public List<ProductsTB> pro { get; set; }
        //public List<OrderTB> Orders { get; set; }

    }
}
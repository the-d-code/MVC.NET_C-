using System;
using System.Collections.Generic;

namespace ExternalTEST.Models
{
    public partial class ProductTb
    {
        public ProductTb()
        {
            OrderTb = new HashSet<OrderTb>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<OrderTb> OrderTb { get; set; }
    }
}

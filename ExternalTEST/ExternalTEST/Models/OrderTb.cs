using System;
using System.Collections.Generic;

namespace ExternalTEST.Models
{
    public partial class OrderTb
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? Qty { get; set; }

        public virtual CustomerTb Customer { get; set; }
        public virtual ProductTb Product { get; set; }
    }
}

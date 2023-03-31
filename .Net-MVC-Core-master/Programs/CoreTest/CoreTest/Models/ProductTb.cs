using System;
using System.Collections.Generic;

namespace CoreTest.models
{
    public partial class ProductTb
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? MfgDate { get; set; }
        public decimal? Price { get; set; }
        public bool? IsAvailable { get; set; }

        public virtual CategoryTb Category { get; set; }
    }
}

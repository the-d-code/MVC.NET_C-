using System;
using System.Collections.Generic;

namespace ExternalTEST.Models
{
    public partial class CustomerTb
    {
        public CustomerTb()
        {
            OrderTb = new HashSet<OrderTb>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual ICollection<OrderTb> OrderTb { get; set; }
    }
}

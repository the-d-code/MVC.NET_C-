using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace External_OnlineSaling.Models
{
    public class OrderClass
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public long TotalAmount{ get; set; }

        public int ProductId { get; set; }
        public int Qty { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }

    }
}
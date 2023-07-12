using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMVC.Models
{
    public class Book
    {
       public int BookId { get; set; }

      public  string BookTitle { get; set; }

        public  float Cost { get; set; }
            
    }
}
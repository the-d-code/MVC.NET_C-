using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Models
{
    public class Book
    {
        //List<Book> My_List = new List<Book>();
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string  Author{ get; set; }

        public int Price { get; set; }


        public Book(int Bno, string Bname, string Aname, int price)
        {
            BookId = Bno;
            BookName = Bname;
            Author = Aname;
            Price = price;

        }
    }
}

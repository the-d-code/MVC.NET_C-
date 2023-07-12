using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            //var dt = from b in dc.books where b.price < 100 select new { b.price, b.bname, b.author, b.subject };
            //var dt = from b in dc.books where b.subject=="java" select new { b.author};
            var dt = from b in dc.books
                     join bo in dc.borrowers 
                     on b.bookid equals bo.bookid
                     where b.subject == "c#"
                     select new { bo.boname, bo.address, bo.phoneno };
            foreach (var v in dt)
            {
                Console.WriteLine(v.boname +" "+v.address+" "+v.phoneno);
            }
            Console.ReadKey();
        }
    }
}

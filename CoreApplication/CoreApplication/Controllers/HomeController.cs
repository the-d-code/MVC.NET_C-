using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreApplication.Models;

namespace CoreApplication.Controllers
{
    
    public class HomeController : Controller
    {
        List<Book> booklist = new List<Book>();
        List<ValueTuple<int, string, string, int>> TupleBook = new List<ValueTuple<int, string, string, int>>();
        Book b = new Book(1101, "C# 7.0", "abc", 200);
        Book b2 = new Book(1102, "F# 7.0", "pqr", 300);
        Book b3 = new Book(1103, "ASP", "xyz", 400);
        Book b4 = new Book(1104, "Java ", "mno", 500);
        Book b5 = new Book(1105, "Node", "jkl", 600);
        Book b6 = new Book(1103, "ASP", "xyz", 400);

      

        public IActionResult Index()
        {
            Book[] bookobj = { b, b2, b3, b4, b5, b6 };

            foreach (Book j in bookobj)
            {
                booklist.Add(j);
            }

            foreach (Book v in booklist)
            {
                TupleBook.Add(ValueTuple.Create(v.BookId, v.BookName, v.Author, v.Price));

            }



            return View(TupleBook.ToList());
        }

        public IActionResult Search()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Search(string bname)
        {
            Book[] bookobj = { b, b2, b3, b4, b5, b6 };

            foreach (Book j in bookobj)
            {
                booklist.Add(j);
            }
            
            var i = from x in booklist where x.BookName == bname select x;
            return View(i.ToList());
        }

      

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

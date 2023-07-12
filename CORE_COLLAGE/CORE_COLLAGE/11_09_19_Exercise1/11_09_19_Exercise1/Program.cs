using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_09_19_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Book> My_List = new List<Book>();
            List<ValueTuple<int, string, string, int, string>> TupleBook = new List<ValueTuple<int, string, string, int, string>>();
            
            Book b1 = new Book(1101, "C# 7.0", "abc", 200, ".Net");
            Book b2 = new Book(1102, "F# 7.0", "pqr", 300, ".Net");
            Book b3 = new Book(1103, "ASP", "xyz", 400, ".Net");
            Book b4 = new Book(1104, "Java ", "mno", 500, "cpp");
            Book b5 = new Book(1105, "Node", "jkl", 600, "cpp");
            Book[] bookobj = {b1, b2, b3, b4, b5};
           
            foreach( Book j in bookobj)
            {
                My_List.Add(j);
            }

           
            int ch = 0;
            do
            {
                Console.WriteLine("Enter your choice:");
                ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        var t1 = from b in bookobj select b ;
                        foreach(Book bfirst in t1)
                        {
                            ValueTuple<string, int> book = (bfirst.BookName, bfirst.Price);
                            Console.WriteLine("BookName:" + book.Item1 + "\n" + "Price:" + book.Item2);
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        var t2 = from b in bookobj select b;
                        foreach (Book bsecond in t2)
                        {
                            ValueTuple<int,string,string,int,string> book = ( bsecond.BookNo, bsecond.BookName,bsecond.AuthorName, bsecond.Price,bsecond.BookType);
                            Console.WriteLine("BookNo:"+book.Item1+"\n"+"BookName:" + book.Item2 + "\n" + "AuthorName:" + book.Item3 + "\n" + "Price:" + book.Item4+"\n"+ "BookType:" + book.Item5 + "\n" );
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("(c)using deconstruct");
                        foreach (Book j in bookobj)
                        {
                            (int BookNo, string BookName, string AuthorName, int Price, string BookType) = j;
                            Console.WriteLine($"BookNo:{BookNo},BookName:{BookName},AuthorName:{AuthorName},Price:{Price},BookType:{BookType}");
                        }

                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Book Collection to Tuple Collection");
                        var totalcost = 0;

                        foreach (Book b in My_List)
                        {
                            TupleBook.Add(ValueTuple.Create(b.BookNo,b.BookName,b.AuthorName,b.Price,b.BookType));
                        }
                        foreach(var book in TupleBook)
                        {
                            Console.WriteLine(book);
                        }
                        foreach (var book2 in TupleBook)
                        {
                            
                              totalcost=totalcost+(book2.Item4);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Total cost:" + totalcost);
                        Console.WriteLine();
                        Console.WriteLine("Average:");
                        var avg = (totalcost / TupleBook.Count);
                        Console.WriteLine("Average cost:" + avg); 
                       
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Total cost of all books:");
                        //var totalcost = 0;
                        foreach(var book2 in TupleBook)
                        {                           
                            Console.WriteLine(book2);
                            //totalcost=totalcost+(book2.Item4);
                        }
                       // Console.WriteLine("Total cost:" + totalcost);
                        Console.WriteLine();
                        break;
                }

            } while (ch != 0);
        }

        class Book
        {
            public int BookNo { get; }
            public string BookName { get; }
            public string AuthorName { get; }
            public int Price { get; }
            public string BookType { get; }

            public Book(int Bno, string Bname, string Aname, int price, string Btype)
            {
                BookNo = Bno;
                BookName = Bname;
                AuthorName = Aname;
                Price = price;
                BookType = Btype;
            }

            public void Deconstruct(out int Bno, out string Bname, out string Aname, out int price, out string Btype)
            {
                Bno = BookNo;
                Bname = BookName;
                Aname = AuthorName;
                price = Price;
                Btype = BookType;
            }




        }

    }
}

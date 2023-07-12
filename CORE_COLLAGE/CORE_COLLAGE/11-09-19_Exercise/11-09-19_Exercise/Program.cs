using System;
using System.Collections.Generic;

namespace _11_09_19_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TupleCheck();
            BookTuple();

            //Book b1 = new Book(12, "snehal");
            //Console.WriteLine($"{b1.BookNo},{b1.BookName}");


        }

        private static void TupleCheck()
        {
            ValueTuple<int, int, string> student = new ValueTuple<int, int, string>(1, 20, "Snehal");
            Console.WriteLine("Roll No:" + student.Item1);
            Console.WriteLine("Age:" + student.Item2);
            Console.WriteLine("Name:" + student.Item3);

        }

        private static void BookTuple()
        {
            
            (int BookNo, string BookName, string Auther, string Price, float Version, string PublishDate) Book = (101,"C#","abc","600",1.2F,"22-08-2017");
            Console.WriteLine("Get 2 values from book:");
            Console.WriteLine("Book Name:" + Book.BookName);
            Console.WriteLine("Price:" + Book.Price);

            Console.WriteLine();

            Console.WriteLine("Get all info. of a book");

            //var b1 = new Book(101, "C#");
            //(int BookNo, string BookName) = b1;
            //Console.WriteLine($"BookNo:{BookNo},BookName:{BookName}");

            Console.WriteLine();
            Console.WriteLine("(c)using deconstruct");
            var b1 = new Book(101, "C##", "abc", 450, ".net");
            (int BookNo,string BookName, string AuthorName,int Price,string BookType) = b1;
            Console.WriteLine($"BookNo:{BookNo},BookName:{BookName},AuthorName:{AuthorName},Price:{Price},BookType:{BookType}");

            Console.WriteLine();
            Console.WriteLine(" Book Collection to tuple collection:");
            List<Book> My_List = new List<Book>();
            My_List.Add(b1);
            




        }

        class Book
        {
            public int BookNo { get; }
            public string BookName { get; }
            public string AuthorName { get; }
            public int Price { get; }
            public string BookType { get; }

             public Book(int Bno,string Bname,string Aname,int price,string Btype)
            {
                BookNo = Bno;
               BookName = Bname;
                AuthorName = Aname;
                Price = price;
                BookType = Btype;
            }

            public void Deconstruct(out int Bno,out string Bname,out string Aname,out int price,out string Btype)
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

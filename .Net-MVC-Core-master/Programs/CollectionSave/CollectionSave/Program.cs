using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace CollectionSave
{
    class Program
    {
       

     
        static void Main(string[] args)
        {
            List<Book> BookList = new List<Book>();
            int ch;

            do
            {
                Console.WriteLine("1.Add Boook");
                Console.WriteLine("2.Show Books");
                Console.WriteLine("0.Exit");

                Console.WriteLine("Please Enter Your Choice");
                ch = Convert.ToInt32(Console.ReadLine());
                Book b1 = new Book();
                switch (ch)
                {
                    case 1:
                       
                        Console.WriteLine("Enter Boook No-" );
                        b1.BookNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Book Name");
                        b1.Bookname = Console.ReadLine();

                        Console.WriteLine("Enter Author Name");
                        b1.author = Console.ReadLine();

                        Console.WriteLine("Enter Price");
                        b1.price = Convert.ToInt64( Console.ReadLine());


                        Stream stream = File.Open(@"E:\BookInfo.txt", FileMode.Create);
                        BinaryFormatter bf = new BinaryFormatter();

                        Console.WriteLine("Writing in file");
                        BookList.Add(b1);
                        bf.Serialize(stream, BookList);
                        stream.Close();

                        
                        b1 = null;

                        break;
                    case 2:
                        Stream stream1 = File.Open(@"E:\BookInfo.txt", FileMode.Open);
                        bf = new BinaryFormatter();
                        List<Book> blist;
                        Console.WriteLine("Reading From File");
                        blist = (List<Book>)bf.Deserialize(stream1);

                        stream1.Close();

                        foreach(var i in blist)
                        {
                            Console.WriteLine(i.Bookname + " " + i.author + " " + i.price);
                        }
                        break;
                    case 0:
                        break;
                }


            } while (ch != 0);
        }
    }
    [Serializable()]
    class Book:ISerializable
    {   
        public int BookNo { get; set; }
        public string Bookname { get; set; }

        public string author { get; set; }

        public Int64 price { get; set; }


        public Book()
        {
            BookNo = 0;
            Bookname = null;
            author = null;
            price = 0;
        }
        public Book(SerializationInfo info,StreamingContext ctxt)
        {
            BookNo = (int)info.GetValue("BookNo", typeof(int));
            Bookname = (string)info.GetValue("Bookname", typeof(string));
            author = (string)info.GetValue("Author", typeof(string));
            price = (Int64)info.GetValue("Price", typeof(Int64));

        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("BookNo", BookNo);
            info.AddValue("Bookname", Bookname);
            info.AddValue("Author", author);
            info.AddValue("Price", price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerQ
{
   public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int MaxBuyingCapacity { get; set; }

        public override string ToString()
        {
            return "CustomerID=" + CustomerId
                + "\t Name=" + CustomerName
                + "\t Age=" + Age
                + "\t State=" + State
                + "\t City=" + City
                + "\t Capacity=" + MaxBuyingCapacity;
        }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Rate { get; set; }
        public int Quantity{ get; set; }
    }
    public class SalesOrder
    {
        public Customer customer;
        public List<Product> products;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> obj = new List<Customer>();
            obj.Add(new Customer {CustomerId=1,CustomerName="Shubham",Age=21,State="Gujarat",City="Surat",MaxBuyingCapacity=70000});
            obj.Add(new Customer { CustomerId = 2, CustomerName = "Meet", Age = 23, State = "MadhyaPradesh", City = "Ujjain", MaxBuyingCapacity = 36000 });
            obj.Add(new Customer { CustomerId = 3, CustomerName = "Hiten", Age = 33, State = "Punjab", City = "Hariyana", MaxBuyingCapacity = 22000 });
            obj.Add(new Customer { CustomerId = 4, CustomerName = "Meet", Age = 40, State = "Gujarat", City = "Surat", MaxBuyingCapacity = 50000 });
            obj.Add(new Customer { CustomerId = 5, CustomerName = "Smita", Age = 39, State = "Maharashtra", City = "Mumbai", MaxBuyingCapacity = 66000 });

            List<Product> productList = new List<Product>();
            productList.Add(new Product { ProductId = 101, ProductName = "Computer", Rate =40000, Quantity = 10 });
            productList.Add(new Product { ProductId = 102, ProductName = "Table", Rate = 12000, Quantity = 56 });
            productList.Add(new Product { ProductId = 103, ProductName = "Chair", Rate = 5000, Quantity = 100 });
            productList.Add(new Product { ProductId = 104, ProductName = "Fan", Rate = 2500, Quantity = 60 });
            productList.Add(new Product { ProductId = 105, ProductName = "AC", Rate = 48000, Quantity = 5});

            List<SalesOrder> salesOrder = new List<SalesOrder>();
            salesOrder.Add(
                new SalesOrder
                {
                    customer = obj.Single<Customer>(c => c.CustomerId == 1),
                    products=new List<Product>(productList.Where(p=>p.ProductId==101 || p.ProductId==103))

                }
                );
            salesOrder.Add(
               new SalesOrder
               {
                   customer = obj.Single<Customer>(c => c.CustomerId == 2),
                   products = new List<Product>(productList.Where(p => p.ProductId == 103 || p.ProductId == 102))

               }
               );
            salesOrder.Add(
               new SalesOrder
               {
                   customer = obj.Single<Customer>(c => c.CustomerId == 3),
                   products = new List<Product>(productList.Where(p => p.ProductId == 101 || p.ProductId == 105 || p.ProductId==104))

               }
               );
            salesOrder.Add(
               new SalesOrder
               {
                   customer = obj.Single<Customer>(c => c.CustomerId == 4),
                   products = new List<Product>(productList.Where(p => p.ProductId == 102 || p.ProductId == 104))

               }
               );
            salesOrder.Add(
               new SalesOrder
               {
                   customer = obj.Single<Customer>(c => c.CustomerId == 5),
                   products = new List<Product>(productList.Where(p => p.ProductId == 101 || p.ProductId == 102))

               }
               );

            #region Queries
            /*var SalesReport = from so in salesOrder
                              where so.products.Contains(
                (from p in productList where p.ProductId == 101 select p).First()
                    )
                              select so;*/

            // var SalesReport = salesOrder.Where(SO => SO.products.Any(p => p.ProductId == 101));

            /* var SalesReport = from so in salesOrder
                               where so.products.Any<Product>(p => p.ProductId == 101 || p.ProductId == 103)
                               select so;*/

            /*var SalesReport = salesOrder.Where(SO => SO.products.Any(p => p.ProductId == 101 || p.ProductId == 103));

            foreach (SalesOrder so in SalesReport)
            {
                Console.WriteLine("Name={0}\t Id={1}",so.customer.CustomerName,so.customer.CustomerId);
                foreach(Product p in so.products)
                {
                    Console.Write("- > " + p.ProductName);
                }
                Console.WriteLine();
            }
            */
            // 1 var chairtable = salesOrder.Where(so => so.products.Any(p => p.ProductName.Equals("Chair") || p.ProductName.Equals("Table")));
            /*var q = from c in salesOrder.Where(p=>p.products.Any(x=>x.ProductName=="Chair") && p.products.Any(y=>y.ProductName=="Table")) select c;  
            foreach (SalesOrder so in q)
            {
                Console.WriteLine("Name={0}\t Id={1}", so.customer.CustomerName, so.customer.CustomerId);
                foreach (Product p in so.products)
                {
                    Console.Write("- > " + p.ProductName);
                }
                Console.WriteLine();
            }*/

            //2

            //4

            var q = from p in salesOrder.Where(s => s.products.Count>3) select p;
            foreach(var w in q )
            {
                Console.WriteLine(w.customer.CustomerName);
            }


            #endregion

            /* var data = from state in obj where state.State.Equals("Gujarat") select state;
             Console.WriteLine("Living In Gujarat");
             foreach(var i in data)
             {
                 Console.WriteLine(i.ToString());
             }
             Console.WriteLine();

             var mumbai = from mum in obj where mum.CustomerName.StartsWith("S") && mum.City.Equals("Mumbai") select mum;
             Console.WriteLine("CustomerName Start With S And Living  In Mumbai");
             foreach (var i in mumbai)
             {
                 Console.WriteLine(i.ToString());
             }
             Console.WriteLine();

             var cap = from caps in obj where caps.MaxBuyingCapacity>40000 &&caps.MaxBuyingCapacity<80000  select caps;
             Console.WriteLine("Capacity Between 40000 & 80000");
             foreach (var i in cap)
             {
                 Console.WriteLine(i.ToString());
             }
             Console.WriteLine();


             double average = obj.Average(s=>s.MaxBuyingCapacity);
             var above = from n in obj where n.MaxBuyingCapacity > average select n;
             Console.WriteLine("Max Average Capacity");
             foreach (var i in above)
             {
                 Console.WriteLine(i.ToString());
             }

             Console.WriteLine();

             var end = from endwith in obj  orderby endwith.CustomerName where endwith.CustomerName.EndsWith("a") select endwith;
             Console.WriteLine("Order By Ascending and EndsWith A");
             foreach (var i in end)
             {
                 Console.WriteLine(i.ToString());
             }
             Console.WriteLine();

             var m = from c in obj where c.State.StartsWith("M") || c.State.StartsWith("G") orderby c.CustomerName descending select c;
             Console.WriteLine("Order By Descending And StateName StartWith Either G or M");
             foreach (var i in m)
             {
                 Console.WriteLine(i.ToString());
             }
             Console.WriteLine();
             */

            Console.ReadKey();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace paper_2012_customer
{
    class Program
    {
        static void Main(string[] args)
        {
            customerDataContext cdc = new customerDataContext();
            //customer who have annual balance >10000 and having a car
            //var cust = from c in cdc.Tables
            //           where c.annualBalance > 10000 && c.ownCar == true
            //           select c;

            //top 3 customer detail respect to opening balance and gender is female
            var cust = (from c in cdc.Tables
                        where c.gender == "female"
                        orderby c.openingBalance descending
                        select c).Take(3);

            //customer whose state is gujarat
            //var cust = from c in cdc.Tables
            //           where c.state == "gujarat"
            //           select c;

            foreach (var c1 in cust)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", c1.customerName, c1.annualBalance, c1.ownCar, c1.gender, c1.openingBalance, c1.state);
            }

            //get city wise customer and average annual income
            var cust1 = from c in cdc.Tables
                       group c by c.city into x
                       select new { x1=x.Key,avg=x.Average(y=>y.annualBalance)};


            foreach (var c2 in cust1)
            {
                Console.WriteLine("{0} {1}",c2.x1,c2.avg);
            }
            

        }
    }
}

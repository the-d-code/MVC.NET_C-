using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_2012
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var dt = from c in dc.customers
                     where c.an_income < 40000 && c.own_car == true
                     select c;
            foreach (var v in dt)
            {
                //Console.WriteLine(v.name + " " + v.phoneno + " " + v.state+" "+v.gender+" "+v.open_balance+" "+v.city+" "+v.an_income+" "+v.own_car);
            }

            var dt1 = (from c in dc.customers
                       where c.gender == "female"
                       orderby c.open_balance descending
                       select c).Take(1);

            foreach (var v in dt1)
            {
                //Console.WriteLine(v.name + " " + v.phoneno + " " + v.state + " " + v.gender + " " + v.open_balance + " " + v.city + " " + v.an_income + " " + v.own_car);
            }

            var dt2 = from c in dc.customers
                      where c.state == "gujarat"
                      select c;

           // Console.WriteLine("id"+" "+"name"+" "+"phoneno");
            foreach (var v in dt2)
            {
               // Console.WriteLine(v.Id + " " + v.name + " " + v.phoneno);
            }

            var dt3 = from c in dc.customers
                      group c by c.city;
                      
            foreach (var v in dt3)
            {
               // Console.WriteLine(v.Average(c => c.an_income)+" "+v.Key);
            }

            //march/april_2015

            var dt4 = from c in dc.customers
                      where c.name.StartsWith("M")
                      select c;

            //Console.WriteLine("id" + " " + "name" + " " + "phoneno");
            foreach (var v in dt4)
            {
               // Console.WriteLine(v.Id + " " + v.name + " " + v.phoneno);
            }

            var dt5 = from c in dc.customers
                      where c.an_income>40000 && c.an_income<80000
                      select c;

           // Console.WriteLine("id" + " " + "name" + " " + "phoneno");
            foreach (var v in dt5)
            {
               //  Console.WriteLine(v.Id + " " + v.name + " " + v.phoneno);
            }

            var dt6 = from d in dc.depts
                      join e in dc.emps 
                      on d.dno equals e.dno
                      where d.dname == "finance" || d.dname=="hr"
                      select new { e.ename, e.sal, d.dname };

            foreach (var v in dt6)
            {
               // Console.WriteLine(v.ename + " " + v.sal + " " + v.dname);
            }

            float[] value = { 1.2f, 1.3f, 4.5f, 5.2f, 6.8f };

            var dt7 = value.Average();

            //  Console.WriteLine(dt7);


            string value1 ="misha" ;

            var dt8 = value1.Replace("i",string.Empty);
            

           // Console.WriteLine(dt8);

            Console.ReadKey();
        }
    }
}

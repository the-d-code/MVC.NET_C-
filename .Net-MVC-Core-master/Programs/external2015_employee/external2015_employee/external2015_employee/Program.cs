using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace external2015_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            employeesDataContext edc = new employeesDataContext();

            //var emp = from e in edc.tblemlpoyees
            //          where e.employeeName.StartsWith("r")
            //          select e;

            //var emp = from e in edc.tblemlpoyees
            //          where e.salary >= 20000 && e.salary <= 60000
            //          select e;

            //var emp = from e in edc.tblemlpoyees
            //          where e.department == "marketing" || e.department == "accounting"
            //          select e;

            //foreach (var e1 in emp)
            //{
            //    Console.WriteLine("{0} {1} {2}",e1.employeeName,e1.salary,e1.department);
            //}


            //remove char t from string
            string str = "test of bhagvati";
            var emp1 = str.Replace("t", String.Empty);
            Console.WriteLine("{0}",emp1);


            //average of 5 float values
            float[] num = new float[] { 1.1f, 12.3f ,50.5f,65.5f,2.9f};
            var avg = num.Average();
            Console.WriteLine("{0}",avg);
            
            
        }
    }
}

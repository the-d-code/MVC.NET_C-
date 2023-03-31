using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace external_2015_paper
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "tara rum pum";
            
            float[] f1 = {10.0f,20.0f,14.0f,15.0f};

            employeeDataContext edc = new employeeDataContext();

            //user whose name start with r
            var query1 = from c in edc.employeeTbs
                         where c.empName.StartsWith("r")
                         select c;

            //vehicle price between 10000 and 18000 (salary between)
            var query2 = from c in edc.employeeTbs
                         where c.empSalary > 10000 && c.empSalary < 18000
                         select c;

            //employess of department hr or accounts
            var query3 = from c in edc.employeeTbs
                      where c.empDepartment == "HR" || c.empDepartment == "accounts"
                      select c;
            
            //remove t from specified string
            name= name.Replace("t","");
            name = name.Replace("t", string.Empty);
            Console.WriteLine("{0}", name);

            //average of 5 values
            var avg=f1.Average();
            Console.WriteLine("{0}", avg);

            //foreach (var e in emp)
            //{
            //    Console.WriteLine("{0}", e);
            //}

            Console.ReadKey();
        }
    }
}

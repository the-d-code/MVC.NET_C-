using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication1
{
    public class Program8
    {
     
        

        static void Main(string[] args)
        {
            int ecode, sal;
            string ename;
            int ch;
            List<Tuple<int, string, int>> listemp = new List<Tuple<int, string, int>>();
            //listemp.Add(Tuple.Create(1, "Shubham", 60000));
            //listemp.Add(Tuple.Create(2, "Snehal", 30000));
            //listemp.Add(Tuple.Create(1, "Jay", 40000));
            //listemp.Add(Tuple.Create(1, "Dharmik", 50000));
            //listemp.Add(Tuple.Create(1, "Vishal", 70000));



            do
            {

                Console.WriteLine("1.Add Employeee-");
                Console.WriteLine("2.Show Employeee-");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Enter Your Choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Code-");
                        ecode = Convert.ToInt16( Console.ReadLine());
                        Console.WriteLine("Enter Name-");
                        ename = Console.ReadLine();
                        Console.WriteLine("Enter Salary-");
                        sal = Convert.ToInt32(Console.ReadLine());
                        listemp.Add(Tuple.Create(ecode,ename,sal));
                        break;
                    case 2:
                        foreach (var i in listemp)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 0:
                        
                        break;
                            
                }


            } while (ch != 0);



           
            Console.ReadKey();
        }
    }
}

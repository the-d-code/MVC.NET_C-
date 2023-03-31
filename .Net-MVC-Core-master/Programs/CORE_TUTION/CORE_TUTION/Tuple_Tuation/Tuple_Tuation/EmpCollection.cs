using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple_Tuation
{
    class EmpCollection
    {
        static void Main(string[] args)
        {
            List<Tuple<int, string, int>> emplist = new List<Tuple<int, string, int>>();
            //emplist.Add(Tuple.Create(1, "snehal", 1000));
            //emplist.Add(Tuple.Create(2, "shubham", 2000));
            //emplist.Add(Tuple.Create(3, "karan", 3000));
            //emplist.Add(Tuple.Create(4, "vaidehi", 4000));
            //emplist.Add(Tuple.Create(5, "krishna", 5000));

            //foreach(var emp in emplist)
            //{
            //    Console.WriteLine(emp);
            //}


            //for(int i=0;i<=3;i++)
            //{
            //    Console.WriteLine("Add data:");
            //    Console.WriteLine("Enter eno:");
            //    int eno = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter ename:");
            //    string ename = Console.ReadLine();
            //    Console.WriteLine("Enter salary:");
            //    int salary = Convert.ToInt32(Console.ReadLine());

            //    emplist.Add(Tuple.Create(eno, ename, salary));
            //}

            //foreach (var emp in emplist)
            //{
            //    Console.WriteLine(emp);
            //}

            Console.WriteLine("1.For Innsert");
            Console.WriteLine("2.For Show");
            Console.WriteLine("0.For Exit");

            int ch = 0;
            do
            {
                Console.WriteLine("Enter your choice:");
                 ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter eno:");
                        int eno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter ename:");
                        string ename = Console.ReadLine();
                        Console.WriteLine("Enter salary:");
                        int salary = Convert.ToInt32(Console.ReadLine());

                        emplist.Add(Tuple.Create(eno, ename, salary));
                        break;
                    case 2:
                        foreach (var emp in emplist)
                        {
                            Console.WriteLine(emp);
                        }

                        break;

                }
            } while(ch!= 0);


        }

       
       
    }
}

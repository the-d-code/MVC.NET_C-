using System;
using System.Collections.Generic;

namespace Tution_PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            var ch = 0;
            List<ValueTuple<int, string, int>> Student_List = new List<ValueTuple<int, string, int>>();
            Console.WriteLine("Hello World!");
            Console.WriteLine("1.Insert");
            Console.WriteLine("2.Delete");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.ShowAll");
         
            do
            {
                Console.WriteLine("Enter Your choice:");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter your roll no:");
                        int rno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your name:");
                        string sname = Console.ReadLine();
                        Console.WriteLine("Enter Your Sem:");
                        int sem = Convert.ToInt32(Console.ReadLine());
                        var stud = (Rno: rno, Sname: sname, Sem: sem);
                        Student_List.Add(stud);
                        break;
                    case 2:
                        foreach( var studobj in Student_List)
                        {
                            (int id, string sname, int sem) tuplestud = (studobj.Item1, studobj.Item2, studobj.Item3);
                            Console.WriteLine("Student RollNo:" + tuplestud.id);
                            Console.WriteLine("Student Name:" + tuplestud.sname);
                            Console.WriteLine("Student Sem:" + tuplestud.sem);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter your roll no for update:");
                        int urno = Convert.ToInt32(Console.ReadLine());
                                int index = Student_List.FindIndex(a=>a.Item1==urno);
                        if(index>=0)
                        {
                            (int id, string sname, int sem) onestud = Student_List.Find(a => a.Item1 == urno);
                            Console.WriteLine(onestud);

                            Console.WriteLine("Enter your name:");
                            string uname = Console.ReadLine();
                            Console.WriteLine("Enter Your Sem:");
                            int usem = Convert.ToInt32(Console.ReadLine());
                            var ustud = (Rno: urno, Sname: uname, Sem: usem);
                            Student_List.RemoveAt(index);
                            Student_List.Insert(index, ustud);
                            Console.WriteLine("Your data is updated..");
                        }                      
                        break;
                    case 4:
                        Console.WriteLine("Enter your roll no for delete:");
                        int drno = Convert.ToInt32(Console.ReadLine());
                        int dindex = Student_List.FindIndex(a => a.Item1 == drno);
                        if (dindex >= 0)
                        {
                            (int id, string sname, int sem) onestud = Student_List.Find(a => a.Item1 == drno);
                            Console.WriteLine(onestud);
                            Student_List.RemoveAt(dindex);
                            Console.WriteLine("Your data will be delete..");
                        }
                        break;
                }

            } while (ch != 0);
        }
    }
}

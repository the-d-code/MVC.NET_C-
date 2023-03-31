using System;
using System.Collections.Generic;
namespace TuplePractise
{
    class Program
    {
        //static void Main1(string[] args)
        //{
        //    List<Tuple<int, string, string>> StudentList = new List<Tuple<int, string, string>>();

        //    int ch;
        //    do
        //    {
        //        Console.WriteLine("1.Insert Record");
        //        Console.WriteLine("2.Display");
        //        Console.WriteLine("0.Exit");

        //        ch = Convert.ToInt32(Console.ReadLine());

        //        switch (ch)
        //        {
        //            case 1:
        //                Console.WriteLine("Enter Roll No-");
        //                int rno = Convert.ToInt32(Console.ReadLine());

        //                Console.WriteLine("Enter Student Name-");
        //                string name = Console.ReadLine();

        //                Console.WriteLine("Enter Surname-");
        //                string surname = Console.ReadLine();

        //                StudentList.Add(Tuple.Create(rno, name, surname));


        //                break;
        //            case 2:
        //                foreach(var i in StudentList)
        //                {
        //                    Console.WriteLine(i);
        //                }
        //                break;
        //        }

        //    } while (ch != 0);

        //}



        public static void Main(string[] args)
        {
            List<ValueTuple<int, string, int>> StudentList = new List<ValueTuple<int, string, int>>();

            int ch;
            do
            {
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                Console.WriteLine("0.Exit");

                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Roll No-");
                        int rno = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Student Name-");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter sem-");
                        int sem = Convert.ToInt32(Console.ReadLine());

                        var stud = (Rno: rno, Name: name, Sem: sem);
                        StudentList.Add(stud);
                        break;
                    case 2:
                        foreach (var student in StudentList)
                        {
                            (int rno, string name, int sem) tuplestud = (student.Item1, student.Item2, student.Item3);
                            Console.WriteLine("Student Rollno-" + tuplestud.rno);
                            Console.WriteLine("Student Name-" + tuplestud.name);
                            Console.WriteLine("Student Sem-" + tuplestud.sem);


                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Roll no for Update");
                        int urno = Convert.ToInt32(Console.ReadLine());

                        int index = StudentList.FindIndex(a => a.Item1 == urno);
                        if (index > 0)
                        {
                            (int id, string name, int sem) onestud = StudentList.Find(a => a.Item1 == urno);
                            Console.WriteLine(onestud);



                            Console.WriteLine("Enter Student Name-");
                            string uname = Console.ReadLine();

                            Console.WriteLine("Enter sem-");
                            int usem = Convert.ToInt32(Console.ReadLine());
                            StudentList.RemoveAt(index);
                            var ustud = (Rno: urno, Name: uname, Sem: usem);
                            StudentList.Insert(index, ustud);

                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter RollNo You Want to Delete");
                        int drno = Convert.ToInt32(Console.ReadLine());
                        int dindex = StudentList.FindIndex(s => s.Item1 == drno);
                        if (dindex > 0)
                        {
                            StudentList.RemoveAt(dindex);
                            Console.WriteLine("Data Deleted...");
                        }
                        break;
                    case 0:
                        break;
                }



            } while (ch != 0);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 22,44,23,64,12,12,36,76,99,83 };

            #region "Operations"
            var Data = values.Take(4);
            //var Data1 = (from v in values orderby v select v);
            //var Data2 = Data1.Reverse();
            //var Data3 = values.Reverse<int>();
            //var Data4 = values.Skip(3).Reverse<int>();
            //var Data5 = values.Reverse();

            foreach(int x in Data)
            {
                Console.WriteLine(x.ToString());
            }
            #endregion

            #region "MoreFunctionality"
            Console.WriteLine("Total Values are"+values.Count().ToString());
            Console.WriteLine("Total conatins value 12: ?" + values.Contains(12).ToString());
            Console.WriteLine("Total contains value 129 ?" + values.Any(x=>x==129).ToString());
            Console.WriteLine("Total Contains Any Values" + values.Any().ToString());
            Console.WriteLine("Total Values Divisable by 5 are" + values.Any(x=>x%5==0).ToString());
            Console.WriteLine("Total Values Divisable by 2 are" + values.Any(x => x % 2 == 0).ToString());
            Console.WriteLine("First Values" + values.First());
            Console.WriteLine("Last Values" + values.Last());
            #endregion

            #region "Operation on Sequence"
            int[] newvalues = { 20,41,23,60,12,14,37 };
            //Console.WriteLine();
            //var allvalues = values.Concat(newvalues);
            //foreach (int x in allvalues)
            //{
            //  Console.WriteLine(x.ToString());
            //}

            Console.WriteLine("Operation ->Union of two List");
            var uniqvalues = values.Union(newvalues);
            foreach(int x in uniqvalues)
            {
                Console.WriteLine(x.ToString());
            }

            var commanvalues = newvalues.Intersect(values);
            foreach (int x in uniqvalues)
            {
                Console.WriteLine(x.ToString());
            }

            #endregion

            #region "Deffred Execution Demo"
            Console.WriteLine("Deffred Execution Demo");
            var listvalues = new List<int>();
            listvalues.Add(5);
            listvalues.Add(4);
            var newlist = listvalues.Select(x => x * 5);
            listvalues.Add(3);
            listvalues.Add(8);
            foreach(int v in newlist)
            {
                Console.WriteLine(v.ToString());
            }

            #endregion


        }
    }
}

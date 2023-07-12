using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication1
{
    public class Program3
    {
        static void Main3(string[] args)
        {
            var data = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

            Console.WriteLine($"{data.Item1} {data.Item2} {data.Item3}");  //Variable Substitution
            Console.WriteLine($"{data.Item7} {data.Rest } {data.Rest.Item1.Item1  } ");  //Variable Substitution


            var data2 = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
            Console.WriteLine($"{data2.Item1} {data2.Item2} {data2.Item3}");  //Variable Substitution
            Console.WriteLine($"{data2.Item7} {data2.Rest } {data2.Rest.Item1  } ");  //Variable Substitution



            Console.ReadKey();
        }
    }
}

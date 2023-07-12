using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication1
{
    public class Program5
    {
        static void Main5(string[] args)
        {
            var person = GetData();
            Console.Write($"Id-{person.Item1},Name-{person.Item2}");
            Console.ReadKey();

        }

        static Tuple<int, string, string> GetData()
        {
            return Tuple.Create(1, "AAA", "Srt");
        }
    }
}

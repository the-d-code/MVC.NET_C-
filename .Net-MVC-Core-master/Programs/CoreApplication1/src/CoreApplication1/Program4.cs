using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication1
{
    public class Program4
    {
        static void Main4(string[] args)
        {

            var person = Tuple.Create(1, "AAA", "Srt");
            show(person);
            Console.ReadKey();
        }

        static void show(Tuple<int, string, string> person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }
    }
}

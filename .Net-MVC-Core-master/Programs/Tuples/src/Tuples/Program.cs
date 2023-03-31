using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var p = (Id:1, FirstName: "AAA", LastName: "Shah");
            Console.WriteLine($"{p.Id} {p.FirstName} {p.LastName}");
        }
    }
}

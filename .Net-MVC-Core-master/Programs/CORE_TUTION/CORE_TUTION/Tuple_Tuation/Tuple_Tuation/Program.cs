using System;

namespace Tuple_Tuation
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");
            var matrix = Tuple.Create(Tuple.Create(10, 12, 14), Tuple.Create(11, 13, 15), Tuple.Create(20, 30, 40));
            Console.WriteLine($"{matrix.Item1}");
            Console.WriteLine($"{matrix.Item2}");
            Console.WriteLine($"{matrix.Item3}");


        }
    }
}

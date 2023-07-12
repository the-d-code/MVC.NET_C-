using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication1
{
    public class Program7
    {
        static void Main7(string[] args)
        {
            //Tuple<int, int,int>[] tupleArray = new Tuple<int, int,int>[10];

            //tupleArray[0] = new Tuple<int, int,int>(10, 10,10);
            //tupleArray[1] = new Tuple<int, int, int>(20, 20, 20);
            //tupleArray[2] = new Tuple<int, int, int>(30, 30, 30);
            //tupleArray[3] = new Tuple<int, int, int>(40, 40, 40);
            //tupleArray[4] = new Tuple<int, int, int>(50, 50, 50);


            //Console.WriteLine($"{tupleArray[0].Item1}");

            var tuple = Tuple.Create(Tuple.Create(720, 750, 780), Tuple.Create(720, 750, 780), Tuple.Create(1000, 900, 800));

            Console.WriteLine($"{tuple.Item1}");
            Console.WriteLine($"{tuple.Item2}");
            Console.WriteLine($"{tuple.Item3}");
            Console.ReadKey();
        }
    }
}

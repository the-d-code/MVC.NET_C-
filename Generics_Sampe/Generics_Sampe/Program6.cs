using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Sampe
{
    namespace GenericApp
    {
        class prog
        {
            public static void add<T>(T x, T y)
            {
                T ans = (dynamic)x + (dynamic)y;
                Console.WriteLine("Add is {0} ", ans);
            }
            public static void sub<T>(T x, T y)
            {
                T ans = (dynamic)x - (dynamic)y;
                Console.WriteLine("Add is {0} ", ans);
            }
            public static void mul<T>(T x, T y)
            {
                T ans = (dynamic)x * (dynamic)y;
                Console.WriteLine("Add is {0} ", ans);
            }
            public static void div<T>(T x, T y)
            {
                T ans = (dynamic)x / (dynamic)y;
                Console.WriteLine("Add is {0} ", ans);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                int x = 10, y = 15;
                prog.add(x, y);

                //sub(x, y);
                //mul(x, y);
                //div(x, y);
            }


        }
    }
}

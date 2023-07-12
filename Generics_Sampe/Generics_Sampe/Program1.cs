using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Sampe
{
    namespace GenericApp
    {

       
        class Program1
        {
            public static T max<T>(T x, T y)
            {
                if ((dynamic)x > (dynamic)y)
                    return x;
                else
                    return y;
                T ans = (dynamic)x + (dynamic)y;
                //Console.WriteLine("Add is {0} ", ans);
            }
             [STAThread]
            static void Main(string[] args)
            {
                int x = 10, y = 15;
                Console.WriteLine("{0}", max(x, y));

                float x1 = 10.45f, y1 = 15.22f;
                Console.WriteLine("{0}", max(x1, y1));

                Console.ReadKey();
            }


        }
    }
}

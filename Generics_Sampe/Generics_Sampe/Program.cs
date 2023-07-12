using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Sampe
{
    class Program
    {

        static void swap<T>(ref T x,ref T y)
        {
            T tmp = x;
            x = y;
            y = tmp ;
        }
        static void Main(string[] args)
        {
            int x = 3, y = 2;
            string st1 = "aaa", st2 = "bbb";
            float a = 2.3f, b = 34.56f;
            
            //Integer Swap
            swap(ref x, ref y);
            Console.WriteLine("{0} {1}", x, y);
          
            //String swap
            swap(ref st1,ref st2);
            Console.WriteLine("{0} {1}", st1 ,st2);

            //Float swap
            swap(ref a, ref b);
            Console.WriteLine("{0} {1}", a,b);
            
            Console.ReadLine();
        }
    }
}

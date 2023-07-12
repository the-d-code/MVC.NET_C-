using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Sampe
{
    class Test<T1, T2>
    {
        public T1 x;
        public T2 y;
        public Test(T1 x, T2 y)
        {
            this.x = x;
            this.y = y;
        }
        public void show()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
    }
    class Program3
    {

        static void Main(string[] args)
        {
            Test<int, string> t1 = new Test<int, string>(33,"sdf");
            t1.show();

            
            Test<int, float> t2 = new Test<int, float>(33, 45.22f);
            t2.show();

            Console.ReadKey();
        }
    }
}

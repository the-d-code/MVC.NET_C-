using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Test<int> t1 = new Test<int>();
            t1.getdata();
            t1.show();
            Test<string> t2 = new Test<string>();
            t2.getdata();
            t2.show();

        }
    }
    class Test<T1>
    {
        T1 x;
        public void getdata()
        {
            Console.WriteLine("Enter data");
            if(typeof(T1).Name.Equals("Int32"))
            {
                x = (dynamic)Int16.Parse(Console.ReadLine());
            }
            else if(typeof(T1).Name.Equals("String"))
            {
                x = (dynamic)Console.ReadLine();
            }
        }
        public void show()
        {
            Console.WriteLine("{0}",x);
        }
    }

}

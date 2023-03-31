using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Sampe
{
    class MyStack<T>
    {
        public T[] ar;
        public MyStack(int n)
        {
            ar = new T[n];
        }
        public void input()
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                Console.WriteLine("Enter the data");
                if (typeof(T).Name.Equals("Int32"))
                    ar[i] = (dynamic)Int32.Parse(Console.ReadLine());
                if (typeof(T).Name.Equals("Int64"))
                    ar[i] = (dynamic)Int64.Parse(Console.ReadLine());
                if (typeof(T).Name.Equals("Int16"))
                    ar[i] = (dynamic)Int16.Parse(Console.ReadLine());

            }
        }
        public void show()
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                Console.WriteLine("{0}",ar[i]);
                
            }
        }

    }
    class Program2
    {

        static void Main(string[] args)
        {
            MyStack<short> s1 = new MyStack<short>(5);
            s1.input();
            s1.show();

            MyStack<long> s2 = new MyStack<long>(5);
            s2.input();
            s2.show();
           
            
            Console.ReadKey();
        }
    }
}

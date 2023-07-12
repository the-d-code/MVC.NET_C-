using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Mydata<T>
    {
        T[] x;
       public  Mydata(int n)
        {
            x = new T[n];
        }
        public void input()
        {
            int size = x.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter data");
                if (typeof(T).Name.Equals("Int32"))
                {
                    x[i] = (dynamic)Int32.Parse(Console.ReadLine());
                }
                else if (typeof(T).Name.Equals("Float"))
                {
                    x[i] = (dynamic)float.Parse(Console.ReadLine());
                }
                else if (typeof(T).Name.Equals("Double"))
                {
                    x[i] = (dynamic)double.Parse(Console.ReadLine());
                }
            }
        }
        public void show()
        {
            int size = x.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}", x[i]);
            }
        }
        public void sort()
        {
            int size = x.GetLength(0);
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size;j++)
                {
                    T temp;
                    if((dynamic)x[j]>(dynamic)x[i])
                    {
                        temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mydata<int> m1 = new Mydata<int>(5);
            m1.input();
            m1.show();
            m1.sort();
            m1.show();
            Console.ReadKey();

        }
    }
}
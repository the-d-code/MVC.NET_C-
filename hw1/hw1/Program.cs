using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw1
{
   public class Mydata<T>
    {
        T[ ] x;
        Mydata(int n)
        {
            x = new T[n];
        }
        public void input()
        {
            int size = x.GetLength(0);
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("Enter data");
                if(typeof(T).Name.Equals("Int32"))
                {
                    x[i] = (dynamic)Int32.Parse(Console.ReadLine());
                }
                else if(typeof(T).Name.Equals("Float"))
                {
                    x[i] = (dynamic)float.Parse(Console.ReadLine());
                }
                else if(typeof(T).Name.Equals("Double"))
                {
                    x[i] = (dynamic)double.Parse(Console.ReadLine());
                }
            }
        }
        public void show()
        {
            int size = x.GetLength(0);
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("{0}", x[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mydata<int> m1 = new Mydata<int>(5);
              
        }
    }
}

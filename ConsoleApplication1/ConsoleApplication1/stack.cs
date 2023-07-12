using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class stack
    {
        public static void Main(string []args)
        {

        }
    }
    class Test<T>
    {
        int n,top;
        T[] ar;

        public Test(int size)
        {
            n = size;
            ar = new T[n];
            top = -1;
        }
        public void Push()
        {
            if(top==n)
            {
                Console.WriteLine("Stack is OverFlow");
                return;
            }
            else
            {
                Console.WriteLine("Enter Data");
                data = (T)Convert.ChangeType(data,typeof(T));
                ar[top] =(dynamic)data;
                top++;

            }
        }
    }
}

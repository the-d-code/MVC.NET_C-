using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Sampe
{
        public class MyGenericArray<T>
        {
            private T[] array;
            public MyGenericArray(int size)
            {
                array = new T[size];
            }

            public T getItem(int index)
            {
                return array[index];
            }

            public void setItem(int index, T value)
            {
                array[index] = value;
            }
        }

        class Program4
        {
            static void Main(string[] args)
            {

                //declaring an int array
                MyGenericArray<int> intArray = new MyGenericArray<int>(5);

                //setting values
                for (int i = 0; i < 5; i++)
                {
                    intArray.setItem(i, i);
                }

                //retrieving the values
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(intArray.getItem(i) + " ");
                }

                Console.WriteLine();

                //declaring a character array
                MyGenericArray<char> charArray = new MyGenericArray<char>(5);

                //setting values
                for (int i = 0; i < 5; i++)
                {
                    charArray.setItem(i, (char)(i +65));
                }

                //retrieving the values
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(charArray.getItem(i) + " ");
                }
                Console.WriteLine();

                Console.ReadKey();
            }
        }
  
}

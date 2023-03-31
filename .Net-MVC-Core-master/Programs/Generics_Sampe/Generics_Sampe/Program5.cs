using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Sampe
{
    namespace GenericApp
    {
        public class TestClass<T>
        {
            // define an Array of Generic type with length 5
            T[] obj = new T[5];
            T[,] a = new T[3, 3];
            int count = 0;

            // adding items mechanism into generic type
            public void Add(T item)
            {
                //checking length
                if (count + 1 < 6)
                {
                    obj[count] = item;

                }
                count++;
            }
            public T Get(int pos)
            {
                //checking length
                if (pos < count)
                {
                    return obj[pos]; ;

                }
                else
                    return obj [0];
                
            }
            //indexer for foreach statement iteration
            public T this[int index]
            {
                get { return obj[index]; }
                set { obj[index] = value; }
            }
        }
        class Program5
        {
            static void Main(string[] args)
            {
                //instantiate generic with Integer
                TestClass<int> intObj = new TestClass<int>();

                //adding integer values into collection
                intObj.Add(1);
                intObj.Add(2);
                intObj.Add(3);      
                intObj.Add(4);
                intObj.Add(5);
                intObj[2] = 4324;
                //displaying values
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(intObj[i]);    
                }

                Console.WriteLine("Get Data {0}",intObj.Get (0));    
                Console.ReadKey();
            }
            
        }
    }       
}

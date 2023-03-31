using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Sampe
{
    class matrix<T>
    {

        T[,] a ;//= new T[,];
        static int n;
        public matrix(int n1)
        {
            n=n1;
            a = new T[n,n];

        }

        public void input()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter [{0},{1}]=>",i,j);
                    if (typeof(T).Name.Equals("Int16"))
                        a[i, j] = (dynamic)Int16.Parse(Console .ReadLine ());
                    if (typeof(T).Name.Equals("Int32"))
                        a[i, j] = (dynamic)Int32.Parse(Console.ReadLine());
                    if (typeof(T).Name.Equals("float"))
                        a[i, j] = (dynamic)float.Parse(Console.ReadLine());
                    if (typeof(T).Name.Equals("double"))
                        a[i, j] = (dynamic)double.Parse(Console.ReadLine());

                    //a[i,j]=Int16 
                }
            }
        }

        public void show()
        {
            Console.WriteLine("matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t",a[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static matrix<T> operator +(matrix<T> m1, matrix<T> m2)
        {
            matrix<T> m3 = new matrix<T>(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m3.a[i, j] =(dynamic ) m1.a[i, j] + m2.a[i, j];
                }
                
            }
            return m3;
        }

    }

    class main1
    {
        static void Main(string[] args)
        {
            matrix<int> m1 = new matrix<int>(2);
            matrix<int> m2 = new matrix<int>(2);
            matrix<int> m3;


            Console.WriteLine("enter 1st metrix: ");
            m1.input();
            //m1.show();
                        Console.WriteLine("enter 2nd metrix: ");
            m2.input();
            m3 = m1 + m2;
            
            m1.show();
            m2.show();
            m3.show();

            Console.ReadKey();
        }
    }
}

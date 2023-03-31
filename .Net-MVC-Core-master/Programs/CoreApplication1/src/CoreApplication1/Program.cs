using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication1
{
    public class Program
    {
        public static void Main1(string[] args)
        {
            Console.Write("Enter Number 1: ");
            var var1 = Console.ReadLine();
            // Convert string to int  
            int num1 = Convert.ToInt32(var1);

            // Read second number  
            Console.Write("Enter Number 2: ");
            var var2 = Console.ReadLine();
            // Convert string to int  
            int num2 = Convert.ToInt32(var2);

            int ans = num1 + num2;
            Console.WriteLine($"Data is {ans}");  //Variable Substitution
            Console.ReadKey();
        }
    }
}

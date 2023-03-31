using System;


// tuple is a data structure that contains a sequence of elements of different data types. 
//It can be used where you want to have a data structure to hold an object
//with properties, but you don't want to create a separate type for it.

// The last element (the 8th element) will be returned using the Rest property.
namespace ConsoleApp2
{
    class Program6
    {
        static void Main(string[] args)
        {
            int bin = 0b1001_1010_0001_0100;
            int hex = 0x1b_a0_44_fe;
            int dec = 33_554_432;
            int weird = 1_2__3___4____5_____6______7_______8________9;
     

            Console.WriteLine($"Binary {bin}");
            Console.WriteLine($"Hexa {hex}");
            Console.WriteLine($"Decimal {dec}");
            Console.WriteLine($"{weird}");
         
            long num1 = 1_00_10_00_00_00;

            long num3 = 1_00_00_00_00_00_00;


            Console.WriteLine("Num1: {0}", num1);
            Console.WriteLine("Num3: {0}", num3);
        }


    }
}

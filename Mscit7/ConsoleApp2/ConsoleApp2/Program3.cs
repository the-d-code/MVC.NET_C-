using System;


// tuple is a data structure that contains a sequence of elements of different data types. 
//It can be used where you want to have a data structure to hold an object
//with properties, but you don't want to create a separate type for it.

// The last element (the 8th element) will be returned using the Rest property.
namespace ConsoleApp2
{
    class Program3
    {
        static void Main(string[] args)
        {
            var data = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

            Console.WriteLine($"{data.Item1} {data.Item2} {data.Item3}");  //Variable Substitution
            Console.WriteLine($"{data.Item7} {data.Rest } {data.Rest.Item1.Item1  } ");  //Variable Substitution


            var data2 = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
            Console.WriteLine($"{data2.Item1} {data2.Item2} {data2.Item3}");  //Variable Substitution
            Console.WriteLine($"{data2.Item7} {data2.Rest } {data2.Rest.Item1  } ");  //Variable Substitution



            Console.ReadKey();
        }
    }
}

using System;


// tuple is a data structure that contains a sequence of elements of different data types. 
//It can be used where you want to have a data structure to hold an object
//with properties, but you don't want to create a separate type for it.
namespace ConsoleApp2
{
    class Program2
    {
        static void Main(string[] args)
        {

            Tuple<int, string, string> person =
                        new Tuple<int, string, string>(1, "Abc", "Surat");

            var person2 = Tuple.Create(2, "Xyz", "Pune");
            
            Console.WriteLine($"{person.Item1} {person.Item2} {person.Item3}");  //Variable Substitution
            Console.WriteLine($"{person2.Item1} {person2.Item2} {person2.Item3}");  //Variable Substitution
            Console.ReadKey();


           
            
        }
    }
}

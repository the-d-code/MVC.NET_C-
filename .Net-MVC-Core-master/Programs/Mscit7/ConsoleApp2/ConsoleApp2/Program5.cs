using System;


// tuple is a data structure that contains a sequence of elements of different data types. 
//It can be used where you want to have a data structure to hold an object
//with properties, but you don't want to create a separate type for it.

// The last element (the 8th element) will be returned using the Rest property.
namespace ConsoleApp2
{
    class Program5
    {
        static void Main(string[] args)
        {
            var person = GetData();
        }

        static Tuple<int, string, string> GetData()
        {
            return Tuple.Create(1, "AAA", "Srt");
        }

    }
}

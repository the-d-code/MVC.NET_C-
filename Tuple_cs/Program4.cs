//Deconstruction

//Individual members of a ValueTuple can be retrieved by deconstructing it.
// A deconstructing declaration syntax splits a ValueTuple into its parts and 
//assigns those parts individually to fresh variables.

using System;
					
public class Program4
{
	public static void Main(string[] args)
{
    // change property names
    (int PersonId, string FName, string LName) = GetPerson();
	Console.WriteLine($"{PersonId} {FName} {LName}");

	(var PersonId2, var FName2, var LName2) = GetPerson();
	Console.WriteLine($"{PersonId2} {FName2} {LName2}");

	(var PersonId3, var FName3,_ ) = GetPerson();
	Console.WriteLine($"{PersonId3} {FName3} ");

}
static (int, string, string) GetPerson() 
{
    return (Id:1, FirstName: "Aq", LastName: "Shah");
}

}
using System;
					
public class Program2
{
	public static void Main()
	{
		(int Id, string FirstName, string LastName) person = (1, "ABC", "Shah");
 
		Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName}");
	}
}
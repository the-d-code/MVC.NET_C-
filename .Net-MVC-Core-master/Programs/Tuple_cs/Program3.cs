using System;
					
public class Program4
{
	public static void Main()
	{
		(int Id, string FirstName, string LastName) person = (PersonId:1, FName:"AAAl22l", LName: "Shah");

// PersonId, FirstName, LastName will be ignored. It will have the default names: Id,FirstName....

		Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName}");
	}
}
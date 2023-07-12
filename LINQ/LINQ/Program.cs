using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		// Data source
		string[] names = {"Nehal", "Satish", "Minu", "Purvi" };
        
		// LINQ Query 
        var dt =  from name in names
            			   where name.Contains('a')
            				select name;
        
		// Query execution
        foreach (var name in dt)
            Console.Write(name + " ");
	}
}
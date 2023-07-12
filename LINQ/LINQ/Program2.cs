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
            			   where name.StartsWith("N")
            				select name;
        
		// Query execution
        foreach (var name in dt)
            Console.Write(name + " ");
		
		// Lambda Expression
        
		Console.WriteLine("\n Lambda Expression\n");
		var dt2 =  names.Where(s=>s.StartsWith("N"));
		
		Console.WriteLine(" Direct Printing {0} \n",String.Join(",",dt2));
		
		foreach (var name in dt2)
            Console.Write(name + " ");
		
            		
        
		
	}
}
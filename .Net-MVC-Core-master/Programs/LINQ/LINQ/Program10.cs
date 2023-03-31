using System;
using System.Linq;
using System.Collections.Generic;
					
					
public class Program10
{
	public static void Main()
	{
		List<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
		List<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight"};
		
		Console.WriteLine("\n Intersection \n");
		var result = strList1.Intersect(strList2);
		
		foreach(string str in result)
			Console.WriteLine(str);
		
		Console.WriteLine("\n Union \n");
		
		var result2 = strList1.Union(strList2);
		
		foreach(string str in result2)
			Console.WriteLine(str);
		
		Console.WriteLine("\n Except \n");
		var result3 = strList1.Except(strList2);
		
		foreach(string str in result3)
			Console.WriteLine(str);
		
		
		Console.WriteLine("\n Except \n");
		var result4 = strList2.Except(strList1);
		
		foreach(string str in result4)
			Console.WriteLine(str);
		
		
		
	}
}
using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program12
{
	public static void Main()
	{
		List<string> strList = new List<string>(){ "One", "Two", "Three", "Four", "Five" };

		
		Console.WriteLine("\n Result of Take using Query \n");
		var qnewList = (from x in strList select x).Take(3);
		 
		foreach(var str in qnewList)
			Console.WriteLine(str);
		
		Console.WriteLine("\n Result of Take using Lambda \n");
		var newList = strList.Take(3);
		
		foreach(var str in newList)
			Console.WriteLine(str);
		
		
		Console.WriteLine("\n Result of Take using Query \n");
		var qnewList2 = (from x in strList select x).Skip(3);
		 
		foreach(var str in qnewList2)
			Console.WriteLine(str);
		
		Console.WriteLine("\n Result of Skip \n");
		var newList2 = strList.Skip(3);
		
		foreach(var str in newList2)
			Console.WriteLine(str);
	}
}
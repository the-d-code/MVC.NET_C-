//Expression Body with Indexers
using System;
public class Sports
{
    private string[] types = {"Cricket", "Baseball", "Basketball", "Football",
                              "Hockey", "Tennis","Volleyball" };
    public string this[int i]
    {
        get => types[i];
        set => types[i] = value;
    }
}
				
public class Program5
{
	public static void Main()
	{
		 Sports sports = new Sports();
        Console.WriteLine(sports[0]);
        Console.WriteLine(sports[2]);
		
	}
}
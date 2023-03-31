using System;
					
public class Program5
{
	public static void Main(string[] args)
{
   	var valueTuple = (id: 1, name: "Avv", age: 25, dob: DateTime.Parse("1/1/1993"));
		Console.WriteLine($"{valueTuple.id} {valueTuple.name} {valueTuple.age} {valueTuple.dob}");
	var tuple = valueTuple.ToTuple();
	Console.WriteLine($"{tuple.Item1} {tuple.Item2} {tuple.Item3} {tuple.Item4}");

}
}
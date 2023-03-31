//Expression Body Destructor


using System;
public class Destroyer
{
    public override string ToString() => GetType().Name;
    ~Destroyer() => Console.WriteLine($"The {ToString()} destructor is executing.");
}
					
public class Program
{
	public static void Main()
	{
		{
			Destroyer dest=new   Destroyer();
		Console.WriteLine(dest);
		}
		
	}
}
//Local Function in C# Core
using System;
public class Program7
{
  public static void Main()
	{
        int a = 120, b = 15;
        int sum = add1(a, b);
        int difference = sub(a, b);
        Console.WriteLine($"The Sum of {a} and {b} is {sum}");
        Console.WriteLine($"The Difference of {a} and {b} is {difference}");
        int add1(int x, int y)
        {
            return x + y;
        }
        int sub(int x, int y)
        {
            return x - y;
        }
  	
	}
}
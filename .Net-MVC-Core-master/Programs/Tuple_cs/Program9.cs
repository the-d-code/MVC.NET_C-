using System;
					

public class Square
{
    public double Side { get; }

    public Square(double side)
    {
        Side = side;
    }
}
public class Circle
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }
}
public struct Rectangle
{
    public double Length { get; }
    public double Height { get; }

    public Rectangle(double length, double height)
    {
        Length = length;
        Height = height;
    }
}
public class Triangle
{
    public double Base { get; }
    public double Height { get; }

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }
}


public class Program
{
	public static void Main(string[] args)
	{
		Square s=new Square(3);
		Circle c=new Circle(3.2);
		Triangle t=new Triangle(3,2);
		Rectangle r=new Rectangle(3,2);
		
   Console.WriteLine(ComputeAreaSwitch(s));
	Console.WriteLine(ComputeAreaSwitch(c));
		Console.WriteLine(ComputeAreaSwitch(t));
		Console.WriteLine(ComputeAreaSwitch(r));
		
	}
	public static double ComputeAreaSwitch(object shape)
{
    switch (shape)
    {
        case Square s:
            return s.Side * s.Side;
        case Circle c:
            return c.Radius * c.Radius * Math.PI;
        case Rectangle r:
            return r.Height * r.Length;
        case Triangle t:
            return 0.5*t.Base  * t.Height;
        
		default:
            throw new ArgumentException(
                message: "shape is not a recognized shape",
                paramName: nameof(shape));
    }
}	
}



	
	

//Expression Body with Getter & Setter
using System;
using System.Collections.Generic;

class ExprBodiedGettersnSetters
{
    public Dictionary<int, double> EmpBasicSalaryList = new Dictionary<int, double>();
    public int EmpId { get; set; }
    public double EmpBasicSalary
    {
        ///Expression Bodied Getter  
        get => EmpBasicSalaryList[EmpId];
        ///Expression Bodied Setter  
        set => EmpBasicSalaryList[EmpId] = value;
    }
}			
public class Program
{
	public static void Main()
	{
        var obj = new ExprBodiedGettersnSetters();
        obj.EmpBasicSalaryList.Add(101, 1000);
        obj.EmpBasicSalaryList.Add(102, 1200);
        obj.EmpId = 101;
        Console.WriteLine($"The basic salary of EmpId {obj.EmpId} is: {obj.EmpBasicSalary}");
        obj.EmpBasicSalary = 1500;
        Console.WriteLine($"The updated basic salary of EmpId {obj.EmpId} is: {obj.EmpBasicSalary}");
		
	}
}
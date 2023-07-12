using System;

//The Expression Bodied Members 
//Methods Example

					
public class Employee
{
    private string FirstName;
    private string LastName;
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string GetFullName() => $"{FirstName} {LastName}";
    public override string ToString() => $"{FirstName} {LastName}";
    public void DisplayName() => Console.WriteLine(GetFullName());
}
public class Program
{
	public static void Main()
	{

        Employee employee = new Employee("Neha", "Shah");
        employee.DisplayName();
        Console.WriteLine(employee);
        Console.Read();
	}
}
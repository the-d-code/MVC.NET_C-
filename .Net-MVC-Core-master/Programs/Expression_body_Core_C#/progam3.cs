//Expression body constructor multiple value


using System;

public class Location
{
    private string locationName;
	private string city;
    public Location(string name,string ucity) =>(locationName, city) = (name, ucity);
    public string Name
    {
        get => locationName;
        set => locationName = value;
    }
	 public string City
    {
        get => city;
        set => city= value;
    }
}
					
public class Program
{
	public static void Main()
	{
		 Location location = new Location("City Light","Surat");
        Console.WriteLine(location.Name);
		location.Name="Pune";
		Console.WriteLine(location.Name);
	}
}
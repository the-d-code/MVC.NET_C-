using System;
					

class Person {  
    private string name;  
    private Int16 age;  
    private string sex;  
    public string Name {  
        get {  
            return this.name;  
        }  
        set {  
            this.name = value;  
        }  
    }  
    public Int16 Age {  
        get {  
            return this.age;  
        }  
        set {  
            this.age = value;  
        }  
    }  
    public string Sex {  
        get {  
            return this.sex;  
        }  
        set {  
            this.sex = value;  
        }  
    }  
}  
// Author class      
class Author: Person {  
    private string book_title;  
    private Int16 pub_year;  
    public string Title {  
        get {  
            return this.book_title;  
        }  
        set {  
            this.book_title = value;  
        }  
    }  
    public Int16 Year {  
        get {  
            return this.pub_year;  
        }  
        set {  
            this.pub_year = value;  
        }  
    }  
    public Author(string name, Int16 age, string sex, string book, Int16 year) {  
        this.Name = name;  
        this.Age = age;  
        this.Sex = sex;  
        this.book_title = book;  
        this.pub_year = year;  
    }  
}  
// Reader class      
class Reader: Person {  
    private string interest;  
    private string job;  
    public Reader(string name, Int16 age, string sex, string interest, string job) {  
        this.Name = name;  
        this.Age = age;  
        this.Sex = sex;  
        this.interest = interest;  
        this.job = job;  
    }  
} 

public class Program7
{
	public static void Main(string[] args)
{
	Reader r = new Reader("Ryan", 21, "male", "reading", "developer");  

   switch (r) {  
    case Person person1 when(person1.Age == 43):  
        Console.WriteLine($"Person {person1.Name}");  
        break;  
    case Reader reader1 when(reader1.Age == 21):  
        Console.WriteLine($"Reader {reader1.Name}");  
        break;  
    default:  
        Console.WriteLine("Not found");  
        break;  
}   
		
}



	
	
}
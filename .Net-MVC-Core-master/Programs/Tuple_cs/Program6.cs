// Patterns are introduced in 7.0 to bring power to some existing language operators and statements. Currently, the pattern matching is partially implemented in C# 7.0 and more work is expected to be done in the next versions of the language. As described in the referenced document, the pattern matching feature introduced in C# 7.0 has the following two advantages:

// You can perform pattern matching on any data type, even your own, whereas with if/else, you always need primitives to match.
// Pattern matching can extract values from your expression.
// C# 7.0 introduces pattern matching in two cases, the is expression and the switch statement.


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

public class Program6
{
	public static void Main(string[] args)
{
   	Person p = new Person();  
Author a = new Author("Mand", 33, "male", "ADO.NET Programming", 2003);  
Reader r = new Reader("Ryan2", 21, "male", "reading", "developer");  
if (a is Person)  
Console.WriteLine("Author is a Person");  
else Console.WriteLine("Author is not a person");  
if (a is Reader)  
Console.WriteLine("Author is a Reader");  
else Console.WriteLine("Author is not a Reader");  

		
if (r is Person)  
	Console.WriteLine("Reader is a Person");  
else
	Console.WriteLine("Reader is not a person");  
if (r is Reader)  
	Console.WriteLine("Reader is a Reader");  
else
	Console.WriteLine("Reader is not a Reader");  
if (r is Author)  
	Console.WriteLine("Author is a Reader");  
else
	Console.WriteLine("Author is not a Reader");  

		
}



	
	
}
using System;
using System.Linq;
using System.Collections.Generic;

                    
public class Program
{
    public static void Main()
    {
        List<Student> studentList = new List<Student>() { 
                  new Student() { StudentID = 1, StudentName = "Jinal", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Mohan",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Binal",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Rohan" , Age = 15 } 
    
        };      
        
        // checks whether all the students are teenagers    
        var sumOfAge = studentList.Sum(s => s.Age);

        Console.WriteLine("Sum of all student's age: {0}", sumOfAge);
        
        var totalAdults = studentList.Sum(s => {
            
            if(s.Age >= 18)
                return 1;
            else
                return 0;
        });
   

        
        var maxAge = studentList.Max(s => s.Age);

        Console.WriteLine("Max student's age: {0}", maxAge);
        
        var minAge = studentList.Min(s => s.Age);

        Console.WriteLine("Min student's age: {0}", minAge);
        
        var avgAge = studentList.Average(s => s.Age);

        Console.WriteLine("Average student's age: {0}", avgAge);
        

        var countAge = studentList.Count(s => s.Age>=20);

        Console.WriteLine("student's whose age is above 20: {0}", countAge);
        
        
    }
}

public class Student{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}
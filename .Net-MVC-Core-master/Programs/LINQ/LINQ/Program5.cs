using System;
using System.Linq;
using System.Collections.Generic;

                    
public class Program5
{
    public static void Main()
    {
        // Student collection
        List<Student> studentList = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "Jinal", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Mohan",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Binal",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
                new Student() { StudentID = 5, StudentName = "Rohan" , Age = 15 } 
            };
        
        // LINQ Query Syntax to find out teenager students
        var dt = from s in studentList
                                orderby s.StudentName descending, s.Age 
                                select s;
        Console.WriteLine(" Students Query Method:");
                          
        foreach(Student std in dt){            
            Console.WriteLine(std.StudentName);
        }
        
        //Lambda
        
        var dt1 =  studentList.OrderBy(s=>s.StudentName).ThenBy(s=>s.Age);
                              
        Console.WriteLine(" Students Lambda Method:");
                          
        foreach(Student std in dt1){            
            Console.WriteLine(std.StudentName);
        }
        
        
        var dt2 =  studentList.OrderByDescending(s=>s.StudentName).ThenBy(s=>s.Age);
                              
        Console.WriteLine(" Students Lambda Method:");
                          
        foreach(Student std in dt2){            
            Console.WriteLine(std.StudentName);
        }
        
        
        
    }
}

public class Student{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    
}
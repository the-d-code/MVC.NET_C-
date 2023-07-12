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
        bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);
        
        
        Console.WriteLine(areAllStudentsTeenAger);
        
       

        bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);
        Console.WriteLine(isAnyStudentTeenAger); 
        
    }
}

public class Student{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}
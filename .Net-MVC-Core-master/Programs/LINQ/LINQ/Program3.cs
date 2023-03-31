using System;
using System.Linq;
using System.Collections.Generic;

                    
public class Program3
{
    public static void Main()
    {
        List<Student> studentList = new List<Student>() { 
                  new Student() { StudentID = 1, StudentName = "Jinal", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Mohan",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Binal",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
                new Student() { StudentID = 5, StudentName = "Rohan" , Age = 18 } 
    
        };      
Console.WriteLine("\n Query Method \n ");        
        var groupedResult = from s in studentList
                    group s by s.Age;

        //iterate each group        
        foreach (var ageGroup in groupedResult)
        {
            Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 
                     
            foreach(Student s in ageGroup) // Each group has inner collection
                Console.WriteLine("Student Name: {0}", s.StudentName);
        }
        
        
        var groupedResult2 =studentList.GroupBy(s=>s.Age);
                    
Console.WriteLine("\n Lambda Expression \n ");
        //iterate each group        
        foreach (var ageGroup in groupedResult2)
        {
            Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 
                     
            foreach(Student s in ageGroup) // Each group has inner collection
                s.show();
        }
        
        
        
    }
}

public class Student{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public void show()
    {
             Console.WriteLine("{0} {1} {2} ", StudentID, StudentName,Age);
    }
}
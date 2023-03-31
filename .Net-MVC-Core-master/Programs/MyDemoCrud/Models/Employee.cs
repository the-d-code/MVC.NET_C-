using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemoCrud.Models
{
    public class Employee
    {
        
        
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public  int Salary { get; set; }

        public string Gender { get; set; }

    }
}

using System;
using System.Collections.Generic;

namespace DhavalSirCoreMVCOrganization.Models
{
    public partial class EmployeeTb
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }
    }
}

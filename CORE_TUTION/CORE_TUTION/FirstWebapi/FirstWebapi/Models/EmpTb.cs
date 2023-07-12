using System;
using System.Collections.Generic;

namespace FirstWebapi.Models
{
    public partial class EmpTb
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public int? Salary { get; set; }
        public string Designation { get; set; }
    }
}

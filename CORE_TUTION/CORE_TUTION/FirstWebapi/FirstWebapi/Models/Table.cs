using System;
using System.Collections.Generic;

namespace FirstWebapi.Models
{
    public partial class Table
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public int? Salary { get; set; }
        public byte[] Designation { get; set; }
    }
}

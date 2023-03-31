using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Empname { get; set; }
        public string Desgn { get; set; }
        public int? Salary { get; set; }
    }
}

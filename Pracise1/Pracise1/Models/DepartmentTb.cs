using System;
using System.Collections.Generic;

namespace Pracise1.Models
{
    public partial class DepartmentTb
    {
        public DepartmentTb()
        {
            EmployeeTb = new HashSet<EmployeeTb>();
        }

        public int DepartmentId { get; set; }
        public string Department { get; set; }

        public virtual ICollection<EmployeeTb> EmployeeTb { get; set; }
    }
}

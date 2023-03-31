using System;
using System.Collections.Generic;

namespace CoreDemoBeforeExam.Models
{
    public partial class StudentTb
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
    }
}

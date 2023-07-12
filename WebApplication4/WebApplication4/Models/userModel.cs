using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class userModel
    {
        public int id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string Username { get; set; }
        public string password { get; set; }

        public List<Marks> Markslist { get; set; }

    }

    public class Marks
    {
        public int Marks1 { get; set; }
        public int Marks2 { get; set; }
        public int Marks3 { get; set; }
        public int Total { get; set; }
        public float Percentage { get; set; }
    }
}
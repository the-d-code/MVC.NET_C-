using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace practice.Models
{
    public partial class Salarytb
    {
        public int Sid { get; set; }
        public int? Eid { get; set; }
        public string Salary { get; set; }
      //  [JsonIgnore]
        public Empptb E { get; set; }
    }
}

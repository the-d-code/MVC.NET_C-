using System;
using System.Collections.Generic;

namespace practice.Models
{
    public partial class Empptb
    {
        public Empptb()
        {
            Salarytb = new HashSet<Salarytb>();
        }

        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Desgn { get; set; }
        public int? Did { get; set; }

        public Dept D { get; set; }
        public ICollection<Salarytb> Salarytb { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace practice.Models
{
    public partial class Dept
    {
        public Dept()
        {
            Empptb = new HashSet<Empptb>();
        }

        public int Did { get; set; }
        public string Dname { get; set; }

        public ICollection<Empptb> Empptb { get; set; }
    }
}

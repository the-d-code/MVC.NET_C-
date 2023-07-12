using System;
using System.Collections.Generic;

namespace CoreTest.models
{
    public partial class CategoryTb
    {
        public CategoryTb()
        {
            ProductTb = new HashSet<ProductTb>();
        }

        public int CategoryId { get; set; }
        public string Categiry { get; set; }

        public virtual ICollection<ProductTb> ProductTb { get; set; }
    }
}

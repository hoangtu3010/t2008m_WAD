using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace t2008m_WAD.Models
{
    public class Brand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
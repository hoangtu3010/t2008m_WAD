using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace t2008m_WAD.Models
{
    public class SystemDbContext : DbContext
    {
        public SystemDbContext() : base("T2008M") { }


        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
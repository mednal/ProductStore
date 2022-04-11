using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PS.Domain;

namespace PS.Data
{
    public class PSContext :DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<Provider> Providers{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Chemical> Chemicals{ get; set; }
        public DbSet<Biological> Biologicals{ get; set; }

        public PSContext()
        {

        }

    }
}

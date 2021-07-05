using EcommerceEntitiesLayer3;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceDatabaseLayer2
{
   public class EcomContext :DbContext
    {
        public EcomContext(DbContextOptions<EcomContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set;}
        public DbSet<Catagory> Catagories { get; set;}
    }
}

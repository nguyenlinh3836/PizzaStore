using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace PizzaStore.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Size> Sizes { get; set; }       
    }
}

   

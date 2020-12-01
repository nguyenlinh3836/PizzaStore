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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<Product>()
                .HasRequired<Size>(s => s.CurrentGrade)
                .WithMany(g => g.Products)
                .HasForeignKey<int>(s => s.CurrentGradeId);
        }
    }
}
}
   

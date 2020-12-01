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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
        .HasMany(p => p.Sizes)
        .WithMany(p => p.Products)
        .UsingEntity<ProductSize>(
            j => j
                .HasOne(pt => pt.Size)
                .WithMany(t => t.ProductSizes)
                .HasForeignKey(pt => pt.TagId),
            j => j
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId),
            j =>
            {
                j.Property(pt => pt.PublicationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
                j.HasKey(t => new { t.PostId, t.TagId });
            });
        }
    }
}
   

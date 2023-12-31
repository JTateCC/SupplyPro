using System;
using System.Data.Entity;
using System.Linq;

namespace SupplyPro.Models
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext()
            : base("name=InventoryDbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOptional(p => p.Location) // Product may have a Location (optional)
                .WithMany()                  // Location may be related to multiple Products
                .HasForeignKey(p => p.LocationId); // Foreign key property in Product

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Location> Locations { get; set; }



    }
}
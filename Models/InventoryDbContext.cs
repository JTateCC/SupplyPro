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

        public DbSet<Product> Products { get; set; }



    }
}
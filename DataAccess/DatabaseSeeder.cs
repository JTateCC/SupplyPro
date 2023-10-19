using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupplyPro.Models;


namespace SupplyPro.DataAccess
{
    // TAKE 
    public class DatabaseSeeder
    {
        private readonly InventoryDbContext _context;

        public DatabaseSeeder(InventoryDbContext context)
        {
            _context = context;
        }

        public void SeedTestData()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductName = "Product 1",
                    ProductDescription = "Description for Product 1",
                    SKU = "SKU001",
                    QuantityInStock = 100,
                    UnitPrice = 19.99M
                },
                new Product
                {
                    ProductName = "Product 2",
                    ProductDescription = "Description for Product 2",
                    SKU = "SKU002",
                    QuantityInStock = 75,
                    UnitPrice = 29.99M
                },
                new Product
                {
                    ProductName = "Product 3",
                    ProductDescription = "Description for Product 3",
                    SKU = "SKU003",
                    QuantityInStock = 50,
                    UnitPrice = 39.99M
                },
            };

            _context.Products.AddRange(products);
            _context.SaveChanges();

        }
    }
}

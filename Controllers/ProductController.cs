using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

using SupplyPro.Models;

namespace SupplyPro.Controllers
{
    public class ProductController
    {
        public List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            using (var ProductContext = new InventoryDbContext())
            {
                allProducts = ProductContext.Products.ToList();
            }
            return allProducts;
        }


        public Product GetProductById(int productId)
        {
            Product product = null;
            using (var ProductContext = new InventoryDbContext())
            {
                product = ProductContext.Products.Find(productId);
            }
            return product;
        }

        public void updateProduct(Product product)
        {
            using (var ProductContext = new InventoryDbContext())
            {
                // Assuming you have a reference to the current product
                ProductContext.Entry(product).State = EntityState.Modified;
                ProductContext.SaveChanges();
            }
        }

        public void DeleteProduct(int productId)
        {
            Console.WriteLine(productId);
 {
                using (var ProductContext = new InventoryDbContext())

                {
                    Product product = ProductContext.Products.Find(productId);
                    if (product != null)
                    {
                        ProductContext.Products.Remove(product); // Remove the entity from DbSet
                        ProductContext.SaveChanges(); // Save changes to commit the deletion to the database
                    }
                }
            }

        }

    }
}

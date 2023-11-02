using System;
using System.Collections.Generic;
using System.Linq;
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



    }
}

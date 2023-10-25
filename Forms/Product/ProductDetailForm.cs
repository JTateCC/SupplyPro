using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SupplyPro.Models;

namespace SupplyPro.Forms.Product
{
    public partial class ProductDetailForm : Form
    {
        public ProductDetailForm(int id)
        {
            InitializeComponent();
            var dbContext = new InventoryDbContext();

            // Set the data source of the DataGridView to the Products DbSet
            SupplyPro.Models.Product product = dbContext.Products.Find(id);
            ProductDetailGrid.DataSource = new List<SupplyPro.Models.Product>() { product };
            


        }
    }
}

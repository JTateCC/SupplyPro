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
    public partial class ProductIndexForm : Form
    {
        public ProductIndexForm()
        {
            InitializeComponent();
            // Assuming you have an instance of your DbContext
            var dbContext = new InventoryDbContext();

            // Set the data source of the DataGridView to the Products DbSet
            ProductDataGrid.DataSource = dbContext.Products.ToList();
            

        }

        private void ProductDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is double-clicked (e.RowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                Console.WriteLine(e.RowIndex);
                DataGridViewRow selectedRow = ProductDataGrid.Rows[e.RowIndex];

                // Retrieve the value from the ProductId column (assuming it's in the first column)
                int productId = (int)selectedRow.Cells["ProductId"].Value;

                // Create and open the detail form with the selected ProductId
                Product.ProductDetailForm detailForm = new Product.ProductDetailForm(productId);
                detailForm.ShowDialog();
            }
        }



    }
}

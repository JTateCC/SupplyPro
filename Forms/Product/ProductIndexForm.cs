using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SupplyPro.Models;
using SupplyPro.Controllers;


namespace SupplyPro.Forms.Product
{
    public partial class ProductIndexForm : Form


    {
        ProductController productController = new ProductController();
        private BindingSource allProductBindingSource = new BindingSource();
            public ProductIndexForm()
            {
                InitializeComponent();

            // Assuming you have an instance of your DbContext
                BindGrid();
            }

            private void BindGrid()
            {

               
                ProductDataGrid.DataSource = allProductBindingSource;
                var productList = productController.GetAllProducts();
                var productBindingList = new BindingList<SupplyPro.Models.Product>(productList);
                allProductBindingSource.DataSource = productBindingList;
                
            }

            private void ProductDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                // Check if a valid row is double-clicked (e.RowIndex >= 0)
                if (e.RowIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = ProductDataGrid.Rows[e.RowIndex];

                    // Retrieve the value from the ProductId column (assuming it's in the first column)
                    int productId = (int)selectedRow.Cells["ProductId"].Value;

                    // Create and open the detail form with the selected ProductId
                    Product.ProductDetailForm detailForm = new Product.ProductDetailForm(productId);
                    detailForm.FormClosed += childFormClosed;
                    this.Hide();
                    detailForm.ShowDialog();
                }
            }

            private void addProductBtn_Click(object sender, EventArgs e)
            {
                Product.ProductAddForm createForm = new Product.ProductAddForm();
                createForm.FormClosed += childFormClosed;
                this.Hide();
                createForm.ShowDialog();
            

            }

            private void childFormClosed(object sender, FormClosedEventArgs e)
            {
                BindGrid();
                this.Show();
        }
    }
}

using SupplyPro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyPro.Forms.Product
{
    public partial class ProductAddForm : Form
    {
        private BindingSource productBindingSource = new BindingSource();
        private SupplyPro.Models.Product newProduct = new SupplyPro.Models.Product();

        public ProductAddForm()
        {
            InitializeComponent();
            productNameTextBox.DataBindings.Add("Text", productBindingSource, "ProductName");
            productDescriptionTextBox.DataBindings.Add(
                "Text",
                productBindingSource,
                "ProductDescription"
            );
            skuTextBox.DataBindings.Add("Text", productBindingSource, "SKU");
            quantityTextBox.DataBindings.Add("Text", productBindingSource, "QuantityInStock");
            unitPriceTextBox.DataBindings.Add("Text", productBindingSource, "UnitPrice");

            //Set the data source for the BindingSource

           productBindingSource.DataSource = newProduct;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            // Access the new product data from the BindingSource
            SupplyPro.Models.Product addedProduct = (SupplyPro.Models.Product)productBindingSource.Current;

            // Save the new product to the database using Entity Framework
            using (var dbContext = new InventoryDbContext())
            {
                dbContext.Products.Add(addedProduct);
                dbContext.SaveChanges();
            }

            // Provide feedback to the user
            MessageBox.Show(
                "Product added successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Clear the form fields
            productBindingSource.Clear();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

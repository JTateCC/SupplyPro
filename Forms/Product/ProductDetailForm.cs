using SupplyPro.Controllers;
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
    public partial class ProductDetailForm : Form
    {
        private BindingSource productBindingSource = new BindingSource();
        ProductController productController = new ProductController();
        private SupplyPro.Models.Product currentProduct;

        public ProductDetailForm(int productId)
        {
            InitializeComponent();
            currentProduct = productController.GetProductById(productId);
            productNameTextBox.DataBindings.Add("Text", productBindingSource, "ProductName");
            productDescriptionTextBox.DataBindings.Add(
                "Text",
                productBindingSource,
                "ProductDescription"
            );
            skuTextBox.DataBindings.Add("Text", productBindingSource, "SKU");
            quantityTextBox.DataBindings.Add("Text", productBindingSource, "QuantityInStock");
            unitPriceTextBox.DataBindings.Add("Text", productBindingSource, "UnitPrice");

            // Set the data source for the BindingSource
            productBindingSource.DataSource = currentProduct;
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

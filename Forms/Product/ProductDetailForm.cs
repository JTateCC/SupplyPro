using SupplyPro.Controllers;
using SupplyPro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        bool isEditMode = false;
        TextBox[] productDataControls;

        public ProductDetailForm(int productId)
        {
            InitializeComponent();
            currentProduct = productController.GetProductById(productId);
            currentProduct.PropertyChanged += product_PropertyChanged;
            productDataControls = new TextBox [] { 
                productNameTextBox,
                productDescriptionTextBox,
                skuTextBox,
                quantityTextBox,
                unitPriceTextBox
            };

            
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

            for(int i = 0; i < productDataControls.Length; i++)
            {
                productDataControls[i].ReadOnly = true;
            }
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {

            // if the form is not in edit mode textboxes are made writeable and put form into edit mode
            if (!isEditMode)
            {
                isEditMode = true;
                for (int i = 0; i < productDataControls.Length; i++)
                {
                    productDataControls[i].ReadOnly = false;
                }
                editProductButton.Text = "Lock";
            }
            else
            {
                isEditMode = false;
                for (int i = 0; i < productDataControls.Length; i++)
                {
                    productDataControls[i].ReadOnly = true;
                }
                editProductButton.Text = "Edit Product";

            }
        }
        private void product_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            using (var dbContext = new InventoryDbContext())
            {
                // Assuming you have a reference to the current product
                dbContext.Entry(currentProduct).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
            
        }



        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
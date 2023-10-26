
namespace SupplyPro.Forms.Product
{
    partial class ProductIndexForm

    {

        private System.ComponentModel.IContainer components = null;

        
 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductDataGrid = new System.Windows.Forms.DataGridView();
            this.addProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDataGrid
            // 
            this.ProductDataGrid.AllowUserToAddRows = false;
            this.ProductDataGrid.AllowUserToDeleteRows = false;
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGrid.Location = new System.Drawing.Point(14, 46);
            this.ProductDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.RowHeadersWidth = 51;
            this.ProductDataGrid.RowTemplate.Height = 24;
            this.ProductDataGrid.Size = new System.Drawing.Size(1818, 616);
            this.ProductDataGrid.TabIndex = 0;
            this.ProductDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGrid_CellDoubleClick);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(14, 701);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(361, 75);
            this.addProductBtn.TabIndex = 1;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // ProductIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1328);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.ProductDataGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductIndexForm";
            this.Text = "ProductIndexForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDataGrid;
        private System.Windows.Forms.Button addProductBtn;
    }
}
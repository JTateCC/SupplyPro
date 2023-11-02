namespace SupplyPro.Forms.Product
{
    partial class ProductDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionLabel = new System.Windows.Forms.Label();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.skuLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.editProductButton = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(250, 110);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(232, 22);
            this.productNameTextBox.TabIndex = 0;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(70, 114);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(93, 16);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Product Name";
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(250, 171);
            this.productDescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(232, 22);
            this.productDescriptionTextBox.TabIndex = 2;
            // 
            // productDescriptionLabel
            // 
            this.productDescriptionLabel.AutoSize = true;
            this.productDescriptionLabel.Location = new System.Drawing.Point(70, 174);
            this.productDescriptionLabel.Name = "productDescriptionLabel";
            this.productDescriptionLabel.Size = new System.Drawing.Size(124, 16);
            this.productDescriptionLabel.TabIndex = 3;
            this.productDescriptionLabel.Text = "Product Description";
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(250, 232);
            this.skuTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(232, 22);
            this.skuTextBox.TabIndex = 4;
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.Location = new System.Drawing.Point(74, 233);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(34, 16);
            this.skuLabel.TabIndex = 5;
            this.skuLabel.Text = "SKU";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(250, 294);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(232, 22);
            this.quantityTextBox.TabIndex = 6;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(74, 298);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(105, 16);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Quantity in Stock";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(250, 363);
            this.unitPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(232, 22);
            this.unitPriceTextBox.TabIndex = 8;
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(74, 368);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(64, 16);
            this.unitPriceLabel.TabIndex = 9;
            this.unitPriceLabel.Text = "Unit Price";
            // 
            // editProductButton
            // 
            this.editProductButton.Location = new System.Drawing.Point(74, 448);
            this.editProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(135, 40);
            this.editProductButton.TabIndex = 10;
            this.editProductButton.Text = "Edit Product";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(276, 448);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(160, 40);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 934);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.skuLabel);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(this.productDescriptionLabel);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductDetailForm";
            this.Text = "Product Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.Label productDescriptionLabel;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button cancelBtn;
    }
}
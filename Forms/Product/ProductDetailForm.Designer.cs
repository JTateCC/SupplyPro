﻿namespace SupplyPro.Forms.Product
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
            this.ProductDetailGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDetailGrid
            // 
            this.ProductDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDetailGrid.Location = new System.Drawing.Point(105, 89);
            this.ProductDetailGrid.Name = "ProductDetailGrid";
            this.ProductDetailGrid.RowHeadersWidth = 51;
            this.ProductDetailGrid.RowTemplate.Height = 24;
            this.ProductDetailGrid.Size = new System.Drawing.Size(584, 45);
            this.ProductDetailGrid.TabIndex = 0;
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductDetailGrid);
            this.Name = "ProductDetailForm";
            this.Text = "ProductDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDetailGrid;
    }
}
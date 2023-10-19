namespace SupplyPro.Forms
{
    partial class TestForm
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
            this.reset_db_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reset_db_btn
            // 
            this.reset_db_btn.Location = new System.Drawing.Point(31, 28);
            this.reset_db_btn.Name = "reset_db_btn";
            this.reset_db_btn.Size = new System.Drawing.Size(123, 51);
            this.reset_db_btn.TabIndex = 0;
            this.reset_db_btn.Text = "Reset Database";
            this.reset_db_btn.UseVisualStyleBackColor = true;
            this.reset_db_btn.Click += new System.EventHandler(this.reset_db_btn_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset_db_btn);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reset_db_btn;
    }
}
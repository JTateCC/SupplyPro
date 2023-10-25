using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

using SupplyPro.DataAccess;
using SupplyPro.Models;


namespace SupplyPro.Forms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void reset_db_btn_Click(object sender, EventArgs e)
        {

            using (var context = new InventoryDbContext())
            {
                // Drop tables using raw SQL
                context.Database.ExecuteSqlCommand("DROP TABLE IF EXISTS Products"); // Replace with your table name if needed

                // Create tables and seed data
                context.Database.ExecuteSqlCommand("CREATE TABLE Products(ProductId INT PRIMARY KEY IDENTITY(1, 1),ProductName NVARCHAR(255) NOT NULL,ProductDescription NVARCHAR(MAX),SKU NVARCHAR(50),QuantityInStock INT,UnitPrice DECIMAL(18, 2));");

                // Seed data
                var seeder = new DatabaseSeeder(context);
                seeder.SeedTestData();

                Console.WriteLine("Database reset and seeded.");
            }
            


        }

        private void launchAppBtn_Click(object sender, EventArgs e)
        {
            Product.ProductIndexForm Appform = new Product.ProductIndexForm();
            Appform.ShowDialog();  
            this.Close();
        }
    }
}

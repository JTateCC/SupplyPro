using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyPro
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using(var db =new Models.InventoryDbContext())
            {
                db.Database.CreateIfNotExists();
            }
            Application.Run(new Forms.Product.ProductIndexForm());
        }
    }
}

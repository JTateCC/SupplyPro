using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyPro.Models
{
    public class Product
    {
        
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string SKU { get; set; }

        public int QuantityInStock { get; set; }

        public decimal UnitPrice { get; set; }

    }


}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyPro.Models
{
    public class Product : INotifyPropertyChanged
    {

        private string productName;
        private string productDescription;
        private string sKU;
        private int quantityInStock;
        private decimal unitPrice;


        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName
        {
            get { return productName; }
            set
            {
                if (productName != value)
                {
                    productName = value;
                    OnPropertyChanged(nameof(ProductName));
                }
            }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set
            {
                if (productDescription != value)
                {
                    productDescription = value;
                    OnPropertyChanged(nameof(ProductDescription));
                }
            }
        }

        public string SKU
        {
            get { return sKU; }
            set
            {
                if (sKU != value)
                {
                    sKU = value;
                    OnPropertyChanged(nameof(SKU));
                }
            }
        }

        public int QuantityInStock
        {
            get { return quantityInStock; }
            set
            {
                if (quantityInStock != value)
                {
                    quantityInStock = value;
                    OnPropertyChanged(nameof(QuantityInStock));
                }
            }
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (unitPrice != value)
                {
                    unitPrice = value;
                    OnPropertyChanged(nameof(UnitPrice));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagementSystem.Models
{
    public class Product 
    {
        [Key]
        [Display(Name = "Product No")]
        public int ProductNo { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name= "Cost Price")]
        [DataType(DataType.Currency)]
        public decimal CostPrice { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Qty { get; set; }

        // Parameterless constructor for EF Core
        public Product() { }

        // Optional: Constructor for your own use
        public Product(int productNo, string productName, decimal costPrice, int qty)
        {
            ProductNo = productNo;
            ProductName = productName;
            CostPrice = costPrice;
            Qty = qty;
        }

        // sales price is to be calculated automatically
        [Display(Name = "Sales Price")]
        [DataType(DataType.Currency)]
        [NotMapped]
        public decimal SalesPrice
        {  get
            {
                // calculate sales price as 122.5% of cost price plus VAT 10%
                decimal price = CostPrice * 1.225m;
                decimal VAT = price * 1.10m;
                return Math.Round(VAT, 2);
            }
        }
    }
}

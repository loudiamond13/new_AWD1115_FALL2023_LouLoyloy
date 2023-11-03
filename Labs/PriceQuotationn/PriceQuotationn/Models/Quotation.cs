using System.ComponentModel.DataAnnotations;

namespace PriceQuotationn.Models
{
    public class Quotation
    {

        [Required(ErrorMessage = "Please Enter a Sales Price")]
        [Range(1, 100000, ErrorMessage = "Sales Must Be 1 - 100000")]
        public double? Subtotal { get; set; }


        [Required(ErrorMessage = "Please Enter A Discount Percentage")]
        [Range(0, 100, ErrorMessage = "Discount Percentage Must Be 1 - 100")]
        public double? DiscountPercentage { get; set; }

        public double CalculateDiscount()
        {
            if (Subtotal.HasValue && DiscountPercentage.HasValue)
            {
                return Subtotal.Value * (DiscountPercentage.Value / 100);
            }
            else
            {
                return 0.0;
            }

        }


        public double CalculateTotal()
        {
            if (Subtotal.HasValue)
            {
                double discount = CalculateDiscount();
                return Subtotal.Value - discount;

            }

            else
            {
                return 0.0;
            }
        }
    }
}


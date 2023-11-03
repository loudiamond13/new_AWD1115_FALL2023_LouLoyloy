using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace orderForm.Models
{
    public class OrderForm
    {
        [Required(ErrorMessage = "Please Enter T-Shirt Quantity!")]
        public int? Quantity { get; set; }

        
        public string? DiscountCode { get; set; }

        //regular price
        public double PricePerShirt { get; set; }

        //const tax percentage
        public  double Tax { get; set; }

        public double Subtotal { get; set; }

        public double Total { get; set; }

        //discount codes list
        List<string> discountCodes = new List<string>()
            {
                "6175", "1390","BB88"
            };



        // checks the discount code and returns message
        public string DiscountMessage()
        { 
            string message = "";

            if (DiscountCode == null)
            {
                message = "No Discount Applied.";
            }

            else if (DiscountCode == discountCodes[0])
            {
                message = "30% Discount Applied.";
            }
            else if (DiscountCode == discountCodes[1])
            {
                message = "20% Discount Applied.";
            }
            else if (DiscountCode == discountCodes[2])
            {
                message = "10% Discount Applied.";
            }
            
            else { message = "Invalid Discount Code."; }

            return message;
        }


       

        public double CalculatePricePerShirt()
        {
           
            double price = 15;
            double disc = 0;
            double totalDisc = 0;


            // check if disc code entered match and set the disc percentage
            if (DiscountCode == discountCodes[0])
            {
                disc = 0.3;
            }
             if (DiscountCode == discountCodes[1])
            {
                disc = 0.2;
            }
             if (DiscountCode == discountCodes[2])
            {
                disc = 0.1;
            }
            
             // calculate the discount
            totalDisc = price * disc;
             PricePerShirt = price - totalDisc;
            return PricePerShirt;
          
            
        }

        public string CalculatePricePerShirtString()
        { 
            double price = CalculatePricePerShirt();

            return $"{Quantity.Value} T-Shirts @ {price.ToString("c2") } each.";
        
        }


        public double CalculateSubtotal()
        {
            if (Quantity.HasValue)
            {
                double shirtPrice = CalculatePricePerShirt();
                return Quantity.Value * shirtPrice;

            }
            else {  return 0; }
        }

        public double CalculateTax()
        {
            double subTotal = CalculateSubtotal();
            return subTotal * 0.08;
        
        }

        public double CalculateTotal()
        { 
            double tax = CalculateTax();
            double subTotal = CalculateSubtotal();
            return subTotal + tax;
        
        }

        

    }
}

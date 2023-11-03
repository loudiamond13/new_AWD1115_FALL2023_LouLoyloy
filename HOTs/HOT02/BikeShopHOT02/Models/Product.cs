

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace BikeShopHOT02.Models
{
    public class Product
    {

        // primary Key
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please Enter A Product Name.")]
        public string ProductName { get; set; } = string.Empty;

        
        public string ProductDescShort { get; set; } = string.Empty;
       
        public string ProductDescLong { get; set; } = string.Empty;
        
        public string ProductImage{ get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter The Product Price.")]
        [Range(1, 100000, ErrorMessage = "Please Enter The Product Price Between 1 - 100000")]
        public decimal ProductPrice { get; set; } = 0.00m;

        [Required(ErrorMessage = "Please Enter The Product Quantity.")]
        [Range(1,1000, ErrorMessage = "Please Enter The Product Quantity Between 1 - 1000")]
        public int ProductQty { get; set; } = 0;

        //Foreign Key
        [Required]
        [Range(1, 100, ErrorMessage = "Please Select A Product Category. ")]
        public int CategoryID { get; set; }

        public Category? Category { get; set; }


        





        public string Slug => ProductName?.Replace(' ', '/').ToLower() +'/';
                            //+ '/' + ProductDescShort?.Replace(' ', '/').ToLower();
                       



    }
}

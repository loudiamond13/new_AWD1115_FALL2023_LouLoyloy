using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop_HOT.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name is Required!")]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? Image { get; set; }

        [Required(ErrorMessage = "Product Price is Required!")]
        [Range(1, 100000, ErrorMessage = "Product Price Must be Between 1 and 100000")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; } = 0.0M;

        [Required(ErrorMessage = "Product Quantity is Required!")]
        [Range(1, 100000, ErrorMessage = "Product Quantity Must be Between 1 and 1000")]
        public int Qty { get; set; } = 0;

        //  Foreign key
        [ValidateNever]
        [Required(ErrorMessage = "Category is Required!")]
        public int CategoryID { get; set; }

        //  Navigation property
        [ValidateNever]
        public Category? Category { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower()?? string.Empty;

       // public ICollection<Category?>? category { get; set;}

     
       
    }
}
 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Product
    {
        public int productID {get;set;}
        
        [Required(ErrorMessage = "Please enter the product name.")]
        public string ProductName { get;set;} = string.Empty;

        [Required(ErrorMessage = "Please enter the product description.")]
        public string ProductDescription { get; set; } = string.Empty;


        [Column(TypeName = "decimal(8,2)")]
        [Required(ErrorMessage = "Please enter the product price.")]
        [Range(1,5000, ErrorMessage ="Product price must be > $0.00")]
        public decimal ProductPrice { get; set; }

        [Required(ErrorMessage = "Please enter the product color.")]
        public string ProductColor { get; set; } = string.Empty;

        public string ProductImageURL { get; set; } = string.Empty;



        [Required(ErrorMessage = "Please select a gender.")]
        public int GenderID { get; set; }

        [Required(ErrorMessage = "Please select a product brand.")]
        public int BrandID { get; set; }

        [Required(ErrorMessage = "Please select a product category.")]
        public int CategoryID { get; set; }

        //navigation properties
        public Brand? Brand { get; set; }
        public Gender? Gender { get; set; }
        public Category? Category { get; set; }
    }
}

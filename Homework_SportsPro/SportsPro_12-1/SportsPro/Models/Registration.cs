using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Registration
    {
        [Required]
        public int CustomerID { get; set; }

        [Required]
        public int ProductID { get; set; }

        //navigation properties
        public Customer Customer { get; set; } 

        public Product Product { get; set; } 


    }
}

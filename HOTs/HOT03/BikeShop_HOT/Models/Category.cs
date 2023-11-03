using System.ComponentModel.DataAnnotations;

namespace BikeShop_HOT.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Category Name is Required!")]
        public string CategoryName { get; set; } = string.Empty;

    }
}

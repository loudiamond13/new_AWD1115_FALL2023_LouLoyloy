using System.ComponentModel.DataAnnotations;

namespace BikeShopHOT02.Models
{
    public class Category
    {

        //  Primary key
        public int CategoryID { get; set; } = 0;

        
        public string CategoryDescription { get; set; } = string.Empty;
    }
}

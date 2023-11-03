using BikeShop_HOT.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;

namespace BikeShop_HOT.Models
{
    public class ProductListViewModel
    {
      
            public List<Category>? Categories { get; set; }
            public List<Product>? Products { get; set; }


        public int SelectedCategory { get; set; } = 0;
       

        public string CheckActiveCategory(int category) =>
                category == SelectedCategory ? "active" : "";

           
    }
}

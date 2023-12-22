using DataAccessLibrary.Models;

namespace FinalProject.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product>? Products { get; set; }
        public IEnumerable<Category>? Categories { get; set; }

        public IEnumerable<Brand>? Brands { get; set; }

        public IEnumerable<Gender>? Genders { get; set; }

        
    }
}

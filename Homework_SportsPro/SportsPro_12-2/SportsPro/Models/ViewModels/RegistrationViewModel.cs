using System.Collections.Generic;

namespace SportsPro.Models.ViewModels
{
    public class RegistrationViewModel
    {
        public int CustomerID { get; set; }// foreign key
        public int ProductID { get; set; } // foreign key
        public Customer? Customer { get; set; }
        public IEnumerable<Registration>? Registrations { get; set; }
        public IEnumerable<Customer>? Customers { get; set; }
        public IEnumerable<Product>? Products { get; set; }
       
    }
}

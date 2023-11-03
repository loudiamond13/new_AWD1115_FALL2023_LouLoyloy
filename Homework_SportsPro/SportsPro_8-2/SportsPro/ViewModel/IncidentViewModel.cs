using SportsPro.Models;

namespace SportsPro.ViewModel
{
    public class IncidentViewModel
    {
        public List<Technician>? Technicians { get; set; }
        public List<Incident>? Incidents { get; set; }
        public List<Product>? Products { get; set; }
        public List<Customer>? Customers { get; set; }
    }
}

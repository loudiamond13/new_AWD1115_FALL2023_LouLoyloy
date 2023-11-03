using SportsPro.Models;

namespace SportsPro.Models.ViewModels
{
    public class IncidentViewModel
    {
        public IEnumerable<Technician>? Technicians{ get; set; }

        
        public List<Incident>? Incidents { get; set; }
        public List<Product>? Products { get; set; }
        public List<Customer>? Customers { get; set; }

        public Technician? Technician { get; set; }

        public Incident? Incident { get; set; }
    }
}

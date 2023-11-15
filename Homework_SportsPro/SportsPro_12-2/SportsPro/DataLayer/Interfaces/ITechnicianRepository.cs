using SportsPro.Models;

namespace SportsPro.DataLayer.Interfaces
{
    public interface ITechnicianRepository : IRepository<Technician>
    {
        IEnumerable<Technician> GetASD();

    }
}

using SportsPro.Models;

namespace SportsPro.Repositories.Interfaces
{
    public interface ITechnicianRepository :IRepository<Technician>
    {
        IEnumerable<Technician> GetASD();

    }
}

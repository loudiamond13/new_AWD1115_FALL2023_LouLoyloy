using SportsPro.Models;

namespace SportsPro.Repositories.Interfaces
{
    public interface IIncidentRepository : IRepository<Incident>
    {
        IEnumerable<Incident> GetAllUnassignedIncidents();
        IEnumerable<Incident> GetIncidentForUpdate(int id);

        IEnumerable<Incident> GetAllOpenIncidents();
        IEnumerable<Incident> GetIncidentsOfSelectedTech(int id);



    }
}

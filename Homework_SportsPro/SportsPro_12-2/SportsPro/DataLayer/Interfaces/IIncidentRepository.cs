using SportsPro.Models;

namespace SportsPro.DataLayer.Interfaces
{
    public interface IIncidentRepository : IRepository<Incident>
    {
        IEnumerable<Incident> GetAllUnassignedIncidents();
        IEnumerable<Incident> GetIncidentForUpdate(int id);

        IEnumerable<Incident> GetAllOpenIncidents();
        IEnumerable<Incident> GetIncidentsOfSelectedTech(int id);



    }
}

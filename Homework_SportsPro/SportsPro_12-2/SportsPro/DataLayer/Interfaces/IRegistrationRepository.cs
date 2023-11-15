using SportsPro.Models;

namespace SportsPro.DataLayer.Interfaces
{
    public interface IRegistrationRepository : IRepository<Registration>
    {
        IEnumerable<Registration> GetAllRegistrationsIncludesAll();
    }
}

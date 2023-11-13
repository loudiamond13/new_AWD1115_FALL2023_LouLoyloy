using SportsPro.Models;

namespace SportsPro.Repositories.Interfaces
{
    public interface IRegistrationRepository : IRepository<Registration>
    {
        IEnumerable<Registration> GetAllRegistrationsIncludesAll();
    }
}

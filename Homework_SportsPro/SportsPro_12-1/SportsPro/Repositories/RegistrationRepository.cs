using Microsoft.EntityFrameworkCore;
using SportsPro.Models;
using SportsPro.Repositories.Interfaces;

namespace SportsPro.Repositories
{
    public class RegistrationRepository : Repository<Registration>, IRegistrationRepository
    {
        public RegistrationRepository(SportsProContext ctx) : base(ctx) { }

        public SportsProContext SportsProContext 
        {
            get { return Context as SportsProContext; }
         }

        public IEnumerable<Registration> GetAllRegistrationsIncludesAll()
        {
            return SportsProContext.Registrations.Include(reg => reg.Product)
                                                .Include(reg => reg.Customer)
                                                .ToList();
        }
    }
}

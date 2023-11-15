using Microsoft.EntityFrameworkCore;
using SportsPro.DataLayer.Interfaces;
using SportsPro.Models;

namespace SportsPro.DataLayer
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

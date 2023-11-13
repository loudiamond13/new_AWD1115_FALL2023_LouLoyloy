using Microsoft.EntityFrameworkCore;
using SportsPro.Models;
using SportsPro.Repositories.Interfaces;

namespace SportsPro.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SportsProContext ctx) : base(ctx)
        {
        }

        public SportsProContext SportsProContext 
        {
            get { return Context as SportsProContext; } 
        }
    }
}

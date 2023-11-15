using Microsoft.EntityFrameworkCore;
using SportsPro.DataLayer.Interfaces;
using SportsPro.Models;

namespace SportsPro.DataLayer
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

using SportsPro.Models;
using SportsPro.Repositories.Interfaces;

namespace SportsPro.Repositories
{
    public class TechnicianRepository : Repository<Technician>, ITechnicianRepository
    {


        public TechnicianRepository(SportsProContext ctx) : base(ctx) { }

        public SportsProContext SportsProContext
        {
            get { return Context as SportsProContext; }
        }

        public IEnumerable<Technician> GetASD()
        { 
            return SportsProContext.Technicians.OrderBy(x => x.Name).ToList();
        }
    }
}

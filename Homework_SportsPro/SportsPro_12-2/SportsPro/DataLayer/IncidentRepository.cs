using SportsPro.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SportsPro.DataLayer.Interfaces;

namespace SportsPro.DataLayer
{
    public class IncidentRepository : Repository<Incident>, IIncidentRepository
    {
        public IncidentRepository(SportsProContext ctx)
            : base(ctx)
        {
        }

        public SportsProContext SportsProContext
        {
            get { return Context as SportsProContext; }
        }

        public IEnumerable<Incident> GetAllOpenIncidents()
        {
            return SportsProContext.Incidents.Where(i => i.DateClosed == null)
                                                .ToList();
        }

        public IEnumerable<Incident> GetAllUnassignedIncidents()
        {
            return SportsProContext.Incidents.Where(i => i.TechnicianID == null).ToList();
        }

        public IEnumerable<Incident> GetIncidentsOfSelectedTech(int id)
        {




            return SportsProContext.Incidents.Include(i => i.Technician)
                                                .Include(i => i.Product)
                                                .Include(i => i.Customer)
                                            .Where(i => i.TechnicianID == id && i.DateClosed == null)
                                            .ToList();
        }

        public IEnumerable<Incident> GetIncidentForUpdate(int id)
        {
            return SportsProContext.Incidents.Include(i => i.Technician)
                  .Include(i => i.Product)
                                                    .Include(i => i.Customer)
                .Where(i => i.IncidentID == id);



        }
    }
}

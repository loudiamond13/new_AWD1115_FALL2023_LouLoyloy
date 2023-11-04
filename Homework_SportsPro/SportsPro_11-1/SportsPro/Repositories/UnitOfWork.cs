using SportsPro.Models;
using SportsPro.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SportsPro.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SportsProContext context;
        public UnitOfWork(SportsProContext ctx)
        { 
            context = ctx;
            Incidents = new IncidentRepository(context);
            Technicians = new TechnicianRepository(context);
        }

        public IIncidentRepository Incidents { get; private set; }
        public ITechnicianRepository Technicians { get; private set; }


        public void Update(object ctx)
        {
            if (ctx is Incident)
            {
                context.Incidents.Update((Incident)ctx);
            }
            else 
            {
                context.Technicians.Update((Technician)ctx);
            }
            
        }

      
            

       
       
        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}

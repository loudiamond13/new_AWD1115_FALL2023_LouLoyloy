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
            Customers = new CustomerRepository(context);
            Registrations = new RegistrationRepository(context);
            Products = new ProductRepository(context);
        }

        public IIncidentRepository Incidents { get; private set; }
        public ITechnicianRepository Technicians { get; private set; }
        public ICustomerRepository Customers { get; private set; }
        public IRegistrationRepository Registrations { get; private set; }
        public IProductRepository Products { get; private set; }

        public void Update(object ctx)
        {
            if (ctx is Incident)
            {
                context.Incidents.Update((Incident)ctx);
            }
            else if (ctx is Technician)
            {
                context.Technicians.Update((Technician)ctx);
            }
            else if (ctx is Customer)
            {
                context.Customers.Update((Customer)ctx);
            }
            else if (ctx is Product)
            {
                context.Products.Update((Product)ctx);
            }
            else if (ctx is Registration)
            { 
                context.Registrations.Update((Registration)ctx);
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

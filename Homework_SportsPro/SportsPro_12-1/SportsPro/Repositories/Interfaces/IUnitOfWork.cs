using Microsoft.EntityFrameworkCore;
using SportsPro.Models;
using System;
namespace SportsPro.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IIncidentRepository Incidents { get; }
        ITechnicianRepository Technicians { get; }
        ICustomerRepository Customers { get; }

        IProductRepository Products { get; }

        IRegistrationRepository Registrations { get; }

        
        void Update(object obj);
        int Complete();
    }
}

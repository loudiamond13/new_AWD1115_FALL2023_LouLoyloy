using Microsoft.EntityFrameworkCore;
using SportsPro.Models;
using System;
namespace SportsPro.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IIncidentRepository Incidents { get; }
        ITechnicianRepository Technicians { get; }

        
        void Update(object obj);
        int Complete();
    }
}

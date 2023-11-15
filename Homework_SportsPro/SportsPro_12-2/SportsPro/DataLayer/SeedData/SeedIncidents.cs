using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SportsPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SportsPro.DataLayer.SeedData
{
    internal class SeedIncidents :IEntityTypeConfiguration<Incident>
    {
        public void Configure(EntityTypeBuilder<Incident> entity)
        {
            entity.HasData(
                  new Incident
                  {
                      IncidentID = 1,
                      CustomerID = 1010,
                      ProductID = 1,
                      TechnicianID = 11,
                      Title = "Could not install",
                      Description = "Media appears to be bad.",
                      DateOpened = DateTime.Parse("2020-01-08"),
                      DateClosed = DateTime.Parse("2020-01-10")
                  },
                new Incident
                {
                    IncidentID = 2,
                    CustomerID = 1002,
                    ProductID = 4,
                    TechnicianID = 14,
                    Title = "Error importing data",
                    Description = "Received error message 415 while trying to import data from previous version.",
                    DateOpened = DateTime.Parse("2020-01-09"),
                    DateClosed = null
                },
                new Incident
                {
                    IncidentID = 3,
                    CustomerID = 1015,
                    ProductID = 6,
                    TechnicianID = 15,
                    Title = "Could not install",
                    Description = "Setup failed with code 104.",
                    DateOpened = DateTime.Parse("2020-01-08"),
                    DateClosed = DateTime.Parse("2020-01-10")
                },
                new Incident
                {
                    IncidentID = 4,
                    CustomerID = 1010,
                    ProductID = 3,
                    TechnicianID = null,
                    Title = "Error launching program",
                    Description = "Program fails with error code 510, unable to open database.",
                    DateOpened = DateTime.Parse("2020-01-10"),
                    DateClosed = null
                }
                );
        }
    }
}

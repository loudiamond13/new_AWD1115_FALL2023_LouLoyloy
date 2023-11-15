using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsPro.Models;
using System.Reflection.Emit;

namespace SportsPro.DataLayer.Configuration
{
    internal class RegistrationConfig : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> entity)
        {
            //many to many relationship for registration table

            entity.HasKey(r => new { r.CustomerID, r.ProductID });

            //one-to-many relationship
            //customer and registration
            entity.HasOne(r => r.Customer)
                    .WithMany(c => c.Registrations)
                    .HasForeignKey(r => r.CustomerID);

            //product and registration 
            entity.HasOne(r => r.Product)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(r => r.ProductID);
        }

    }
}

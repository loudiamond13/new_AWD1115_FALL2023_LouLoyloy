using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess.SeedData
{
    internal class SeedBrand : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> entity)
        {
            entity.HasData(
                new Brand
                {
                    BrandID = 1,
                    BrandName = "Nike"
                },
                 new Brand
                 {
                     BrandID = 2,
                     BrandName = "Adidas"
                 },
                  new Brand
                  {
                      BrandID = 3,
                      BrandName = "Puma"
                  },
                   new Brand
                   {
                       BrandID = 4,
                       BrandName = "Crocs"
                   }
                );
        }
    }
}

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
    internal class SeedGender : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> entity)
        {
            entity.HasData(
                new Gender
                {
                    GenderID = 1,
                    GenderName = "Men"
                },
                 new Gender
                 {
                     GenderID = 2,
                     GenderName = "Women"
                 },
                  new Gender
                  {
                      GenderID = 3,
                      GenderName = "Unisex"
                  }

                );
        }
    }
}

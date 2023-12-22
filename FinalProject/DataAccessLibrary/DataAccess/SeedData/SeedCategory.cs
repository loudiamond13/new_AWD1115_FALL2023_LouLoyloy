using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess.SeedData
{
    public class SeedCategory:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasData(
                new Category 
                {
                    CategoryID = 1,
                    CategoryName = "Shoes"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Hoodies/Pullovers"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Slides"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Caps"
                });
        }
    }
}

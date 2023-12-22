using DataAccessLibrary.DataAccess.SeedData;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess
{
    public class NoheasApparelContext : DbContext
    {
        public NoheasApparelContext(DbContextOptions<NoheasApparelContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SeedProduct());
            modelBuilder.ApplyConfiguration(new SeedGender());
            modelBuilder.ApplyConfiguration(new SeedBrand());
            modelBuilder.ApplyConfiguration(new SeedCategory());
        }
    }
}

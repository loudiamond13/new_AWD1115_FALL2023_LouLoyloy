using Microsoft.EntityFrameworkCore;
using System;
using BikeShopHOT02.Models;

namespace BikeShopHOT02.Models
{
    public class BikeShopContext : DbContext
    {
        public BikeShopContext(DbContextOptions<BikeShopContext> options) : base(options) { }
       
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            modelBuilder.Entity<Product>().HasData
                (
                    new Product
                    {
                        ProductID = 1,
                        ProductName = "AeroFlo ATB Wheels",
                        ProductDescShort = "",
                        ProductDescLong = "",
                        ProductImage = "",
                        ProductPrice = (decimal)189,
                        ProductQty = 40,
                        CategoryID = 1
                    },

                    new Product
                    {
                        ProductID = 2,
                        ProductName = "Clear Shade 85-T Glasses",
                        ProductDescShort = "",
                        ProductDescLong = "",
                        ProductImage = "",
                        ProductPrice = (decimal)45,
                        ProductQty = 14,
                        CategoryID = 6
                    },

                    new Product
                    {
                        ProductID = 3,
                        ProductName = "Cosmic Elite Road Warrior Wheels",
                        ProductDescShort = "",
                        ProductDescLong = "",
                        ProductImage = "",
                        ProductPrice = (decimal)165,
                        ProductQty = 22,
                        CategoryID = 1
                    },

                    new Product
                    {
                        ProductID = 4,
                        ProductName = "Cycle-Doc Pro Repair Stands",
                        ProductDescShort = "",
                        ProductDescLong = "",
                        ProductImage = "",
                        ProductPrice = (decimal)166,
                        ProductQty = 12,
                        CategoryID = 4
                    },

                    new Product
                    {
                        ProductID = 5,
                        ProductName = "Dog Ear Aero-Flow Floor Pumps",
                        ProductDescShort = "",
                        ProductDescLong = "",
                        ProductImage = "",
                        ProductPrice = (decimal)55,
                        ProductQty = 25,
                        CategoryID = 6
                    }
                );


            //Wheels, Accessories, Wheels, Components, Accessories

            modelBuilder.Entity<Category>().HasData
                (
                   new Category { CategoryID = 1, CategoryDescription = "Wheels" },
                   new Category { CategoryID = 2, CategoryDescription = "Bikes" },
                   new Category { CategoryID = 3, CategoryDescription = "Clothing" },
                   new Category { CategoryID = 4, CategoryDescription = "Components" },
                   new Category { CategoryID = 5, CategoryDescription = "Car racks" },
                   new Category { CategoryID = 6, CategoryDescription = "Accessories" }
                );
        }

    }
}

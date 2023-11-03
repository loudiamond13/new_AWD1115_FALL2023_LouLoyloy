﻿// <auto-generated />
using BikeShopHOT02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BikeShopHOT02.Migrations
{
    [DbContext(typeof(BikeShopContext))]
    [Migration("20230913101152_Migration02-Categories")]
    partial class Migration02Categories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BikeShopHOT02.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryDescription = "Wheels"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryDescription = "Bikes"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryDescription = "Clothing"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryDescription = "Components"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryDescription = "Car racks"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryDescription = "Accessories"
                        });
                });

            modelBuilder.Entity("BikeShopHOT02.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescLong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescShort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductQty")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 1,
                            ProductDescLong = "",
                            ProductDescShort = "",
                            ProductImage = "",
                            ProductName = "AeroFlo ATB Wheels",
                            ProductPrice = 189m,
                            ProductQty = 40
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 6,
                            ProductDescLong = "",
                            ProductDescShort = "",
                            ProductImage = "",
                            ProductName = "Clear Shade 85-T Glasses",
                            ProductPrice = 45m,
                            ProductQty = 14
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 1,
                            ProductDescLong = "",
                            ProductDescShort = "",
                            ProductImage = "",
                            ProductName = "Cosmic Elite Road Warrior Wheels",
                            ProductPrice = 165m,
                            ProductQty = 22
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 4,
                            ProductDescLong = "",
                            ProductDescShort = "",
                            ProductImage = "",
                            ProductName = "Cycle-Doc Pro Repair Stands",
                            ProductPrice = 166m,
                            ProductQty = 12
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 6,
                            ProductDescLong = "",
                            ProductDescShort = "",
                            ProductImage = "",
                            ProductName = "Dog Ear Aero-Flow Floor Pumps",
                            ProductPrice = 55m,
                            ProductQty = 25
                        });
                });

            modelBuilder.Entity("BikeShopHOT02.Models.Product", b =>
                {
                    b.HasOne("BikeShopHOT02.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

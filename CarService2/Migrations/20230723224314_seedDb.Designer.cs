﻿// <auto-generated />
using CarService2.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarService2.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20230723224314_seedDb")]
    partial class seedDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("CarService2.Classes.Car", b =>
                {
                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArtEndDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Co2Emissions")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DateOfLastV5CIssued")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EngineCapacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EuroStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("MarkedForExport")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MonthOfFirstRegistration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MotStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RealDrivingEmissions")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RevenueWeight")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaxDueDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TaxStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeApproval")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Wheelplan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearOfManufacture")
                        .HasColumnType("INTEGER");

                    b.HasKey("RegistrationNumber");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            RegistrationNumber = "111111",
                            ArtEndDate = "Pending",
                            Co2Emissions = 0,
                            Colour = "Red",
                            CustomerId = 1,
                            DateOfLastV5CIssued = "Pending",
                            EngineCapacity = 0,
                            EuroStatus = "EURO 3",
                            FuelType = "Pending",
                            Make = "Pending",
                            MarkedForExport = false,
                            MonthOfFirstRegistration = "Pending",
                            MotStatus = "Pending",
                            RealDrivingEmissions = "Pending",
                            RevenueWeight = 0,
                            TaxDueDate = "Pending",
                            TaxStatus = "Pending",
                            TypeApproval = "Pending",
                            Wheelplan = "Pending",
                            YearOfManufacture = 1900
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

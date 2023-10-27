﻿// <auto-generated />
using System;
using CarService2.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarService2.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20231027185836_addJsonString")]
    partial class addJsonString
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("CarService2.DB.CarDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EngineCapacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MonthOfFirstRegistration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Colour = "Red",
                            CustomerId = 1,
                            EngineCapacity = 2000,
                            FuelType = "Petrol",
                            Make = "Fiat",
                            MonthOfFirstRegistration = "March,2000",
                            RegistrationNumber = "11111"
                        });
                });

            modelBuilder.Entity("CarService2.DB.CustomerDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Onyx",
                            Email = "customer@mail.com",
                            FullName = "Customer basic",
                            IsDeleted = false,
                            PhoneNumber = "0777"
                        });
                });

            modelBuilder.Entity("CarService2.DB.OrderOfTaskDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataTasks")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegNo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("OrdersDbs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            DataTasks = "{\r\n  \"15w40\": \"Castrol\",\r\n  \"oilFilter\": true\r\n}\r\n",
                            DateTime = new DateTime(2023, 10, 27, 19, 58, 36, 424, DateTimeKind.Local).AddTicks(7097),
                            RegNo = "11111"
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            DataTasks = "{\r\n  \"15w40\": \"Castrol\",\r\n  \"oilFilter\": true\r\n}\r\n",
                            DateTime = new DateTime(2023, 10, 27, 19, 58, 36, 424, DateTimeKind.Local).AddTicks(7109),
                            RegNo = "22222"
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            DataTasks = "{\r\n  \"5w40\": \"Castrol\",\r\n  \"oilFilter\": true\r\n}\r\n",
                            DateTime = new DateTime(2023, 10, 27, 19, 58, 36, 424, DateTimeKind.Local).AddTicks(7117),
                            RegNo = "33333"
                        });
                });

            modelBuilder.Entity("CarService2.DB.TaskDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderTaskId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderTaskId");

                    b.ToTable("TasksDb");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "15W40",
                            Name = "Oil Specification",
                            Note = "Castrol",
                            OrderTaskId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "75W90",
                            Name = "Gear oil Specification",
                            Note = "OMV",
                            OrderTaskId = 1
                        });
                });

            modelBuilder.Entity("CarService2.DB.CarDb", b =>
                {
                    b.HasOne("CarService2.DB.CustomerDb", "Customer")
                        .WithMany("Cars")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CarService2.DB.OrderOfTaskDb", b =>
                {
                    b.HasOne("CarService2.DB.CustomerDb", "CustomerDb")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerDb");
                });

            modelBuilder.Entity("CarService2.DB.TaskDb", b =>
                {
                    b.HasOne("CarService2.DB.OrderOfTaskDb", "OrdersOfTask")
                        .WithMany()
                        .HasForeignKey("OrderTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrdersOfTask");
                });

            modelBuilder.Entity("CarService2.DB.CustomerDb", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
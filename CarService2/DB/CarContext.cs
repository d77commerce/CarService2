using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService2.Classes;
using CarService2.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CarService2.DB
{
    public class CarContext : DbContext
    {
       
       

       

        public CarContext(DbContextOptions<CarContext> optionsBuilderOptions)
            : base(optionsBuilderOptions)
        {
            
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=car_database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for the Cars table
            modelBuilder.ApplyConfiguration(new CarConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for the Cars table
            modelBuilder.Entity<Car>().HasData(
                new Car { RegistrationNumber = "1", ArtEndDate = "2025-02-28" },
                new Car { RegistrationNumber = "4", ArtEndDate = "2024-12-31" }
                // Add other seed data...
            );
        }*/
    }
}

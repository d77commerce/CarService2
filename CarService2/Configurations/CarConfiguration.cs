using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService2.Classes;
using CarService2.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService2.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<CarDb>
    {
        public void Configure(EntityTypeBuilder<CarDb> builder)
        {
            builder.HasData(new CarDb
            {
                Id = 1,
                RegistrationNumber = "11111",
                Make = "Fiat",
                Colour = "Red",
                EngineCapacity = 2000,
                FuelType = "Petrol",
                MonthOfFirstRegistration = "March,2000",
               CustomerId = 1

            });

        }
    }
}

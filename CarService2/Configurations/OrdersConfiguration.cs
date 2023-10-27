using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService2.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService2.Configurations
{
    public class OrdersConfiguration : IEntityTypeConfiguration<OrderOfTaskDb>
    {
        public void Configure(EntityTypeBuilder<OrderOfTaskDb> builder)
        {
            builder.HasData(new List<OrderOfTaskDb>()
            {
                new OrderOfTaskDb()
                {
                    Id = 1,
                    RegNo = "11111",
                    DateTime = DateTime.Now,
                    CustomerId = 1
                },
                new OrderOfTaskDb()
                {
                    Id = 2,
                    RegNo = "22222",
                    DateTime = DateTime.Now,
                    CustomerId = 2,
                 
                },
                new OrderOfTaskDb()
                {
                    Id = 3,
                    RegNo = "33333",
                    DateTime = DateTime.Now,
                    CustomerId = 3
                }
            });
        }
    }
}

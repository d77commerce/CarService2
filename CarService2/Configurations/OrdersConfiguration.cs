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
            builder.HasData(new OrderOfTaskDb()
            {
                Id = 1,
                RegNo = "11111",
                DateTime = DateTime.Now,
                CustomerId = 1
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService2.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json.Linq;

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
                                    CustomerId = 1,
                                 DataTasks = "{\r\n  \"15w40\": \"Castrol\",\r\n  \"oilFilter\": true\r\n}\r\n"
                                },
                                new OrderOfTaskDb()
                                {
                                    Id = 2,
                                    RegNo = "22222",
                                    DateTime = DateTime.Now,
                                    CustomerId = 2,
                                   DataTasks = "{\r\n  \"15w40\": \"Castrol\",\r\n  \"oilFilter\": true\r\n}\r\n"
                                },
                                new OrderOfTaskDb()
                                {
                                    Id = 3,
                                    RegNo = "33333",
                                    DateTime = DateTime.Now,
                                    CustomerId = 3,
                                   DataTasks = "{\r\n  \"5w40\": \"Castrol\",\r\n  \"oilFilter\": true\r\n}\r\n"
                                }
                            });
        }
    }
}

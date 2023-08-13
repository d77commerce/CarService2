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
   public class TaskConfiguration : IEntityTypeConfiguration<TaskDb>
    {
        public void Configure(EntityTypeBuilder<TaskDb> builder)
        {
            builder.HasData(new List<TaskDb>()
            {
                new TaskDb()
                {
                    Id = 1,
                    Name = "Oil Specification",
                    Description = "15W40",
                    Note ="Castrol",
                    OrderTaskId = 1
                },
                new TaskDb()
                {
                    Id=2,
                    Name = "Gear oil Specification",
                    Description = "75W90",
                    Note = "OMV",
                    OrderTaskId = 1
                }
            });
        }
    }
}

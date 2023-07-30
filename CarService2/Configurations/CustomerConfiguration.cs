using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using CarService2.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService2.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerDb>
    {
        public void Configure(EntityTypeBuilder<CustomerDb> builder)
        {
            builder.HasData(new CustomerDb()
            {
               Id = 1,
               FullName = "Customer basic",
               PhoneNumber = "0777",
               Email = "customer@mail.com",
               CompanyName = "Onyx",
               IsDeleted = false
            });
        }
    }
}

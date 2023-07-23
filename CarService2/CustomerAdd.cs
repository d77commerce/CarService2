using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService2
{
    public class CustomerAdd
    {
        public int Id { get; set; } = 1;
        public string FullName { get; set; } = "John Doe";
        public string CompanyName { get; set; } = "non";
        public string PhoneNumber { get; set; } = "077777777";
        public string Email { get; set; } = "john.doe@example.com";
        public bool IsDeleted { get; set; } = false;
    }
}

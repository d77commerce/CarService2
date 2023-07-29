using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService2.DB
{
    public class CarDb
    {

        [Key]
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Colour { get; set; }
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public string MonthOfFirstRegistration { get; set; } 
        public int CustomerId { get; set; }


    }
}

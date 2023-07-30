using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService2.DB
{
    public class CustomerDb
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
        public virtual IEnumerable<CarDb>? Cars { get; set; } = new List<CarDb>();
    }
}

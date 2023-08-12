using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService2.DB
{
    public class OrderOfTaskDb
    {
        [Key]
        public int Id { get; set; }

        public string RegNo { get; set; } = null!;
        public virtual IEnumerable<TaskDb> TaskUnits { get; set; } = new List<TaskDb>();
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public CustomerDb CustomerDb { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}

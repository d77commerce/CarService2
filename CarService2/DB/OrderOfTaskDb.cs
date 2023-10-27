using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService2.DB
{
    public class OrderOfTaskDb
    {
        [Key]
        public int Id { get; set; }

        public string RegNo { get; set; } = null!;
       // public virtual IEnumerable<TaskDb> TaskUnits { get; set; } = new List<TaskDb>();
        public string? DataTasks { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public CustomerDb CustomerDb { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}

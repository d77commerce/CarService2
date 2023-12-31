﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService2.DB
{
    public class TaskDb
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Note { get; set; }
        public int OrderTaskId { get; set; }
        [ForeignKey(nameof(OrderTaskId))]
        public OrderOfTaskDb OrdersOfTask { get; set; }
    }
}

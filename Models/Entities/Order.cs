using System;
using System.Collections.Generic;

namespace Lessons.Models.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateOnly? OrderDate { get; set; }
        public int? ShipperId { get; set; }
    }
}

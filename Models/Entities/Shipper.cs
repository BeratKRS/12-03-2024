using System;
using System.Collections.Generic;

namespace Lessons.Models.Entities
{
    public partial class Shipper
    {
        public int ShipperId { get; set; }
        public string? ShipperName { get; set; }
        public string? Phone { get; set; }
    }
}

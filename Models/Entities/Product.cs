﻿using System;
using System.Collections.Generic;

namespace Lessons.Models.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string? Unit { get; set; }
        public decimal Price { get; set; }
    }
}

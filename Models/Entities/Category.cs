using System;
using System.Collections.Generic;

namespace Lessons.Models.Entities
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
    }
}

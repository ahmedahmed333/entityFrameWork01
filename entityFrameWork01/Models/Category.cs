using System;
using System.Collections.Generic;
using System.Text;

namespace entityFrameWork01.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }      
        public bool IsActive { get; set; }
    }
}

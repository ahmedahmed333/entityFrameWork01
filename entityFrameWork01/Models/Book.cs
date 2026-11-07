using System;
using System.Collections.Generic;
using System.Text;

namespace entityFrameWork01.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int YearPublished { get; set; }
        public bool InStock { get; set; }


    }
}

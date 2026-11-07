using System;
using System.Collections.Generic;
using System.Text;

namespace entityFrameWork01.Models
{
    internal class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? ShortBiography { get; set; }  
        public DateTime DateOfBirth { get; set; }
    }
}

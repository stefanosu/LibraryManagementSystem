using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool isAvailable { get; set; } = false;
        public int bookId { get; set; }

    }
}
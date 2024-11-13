using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Library
    {
        public List<Book>Books { get; set; } 
        public List<User>Users  { get; set; }
        
    }
}
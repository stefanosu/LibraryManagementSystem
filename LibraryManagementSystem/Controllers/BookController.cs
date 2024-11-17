using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore; 
using Microsoft.AspNetCore.Hosting;


///Make this into an API controller for CRUD operations on book other iteration add DB .NET Core
namespace LibraryManagementSystem.Controllers
{
    public class BookController
    {
        private static List<Book> _books = new List<Book>
        {
            new Book { Title = "Communion The Female Search For Love", Author = "Bell Hooks", bookId =  1, isAvailable = true },
            new Book { Title = "Ishamel", Author = "Daniel Quinn", bookId =  2, isAvailable = true },
            new Book { Title = "1984", Author = "George Orwell", bookId =  3, isAvailable = false },
            new Book { Title = "The Innovators Dilenna", Author = "Clayton Christensen", bookId = 4 , isAvailable = false },
        }; 
        

         // Get all books
    }
}
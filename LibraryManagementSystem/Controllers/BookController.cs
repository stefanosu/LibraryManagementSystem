using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

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
        public GetBooks(Book books) 
        {
            _books = books;
        }

        // GET: api/book
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(books);
        }


        //Get Book by ID
        [HttpGet("{id}")]
        public ActionResult<Book>GetBook(int id)
        {
            var book = books.Find(b => b.Id == id);
            return book != null ? Ok(book) : NotFound();
        }
    }

}
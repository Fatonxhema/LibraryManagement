using LibraryManagement.Models;
using LibraryManagement.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace LibraryManagement.Controllers
{   [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    { 
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("getall")]
        public IEnumerable<Book> GetAllBooks()
        { 
            return _bookService.GetAllBooks();
            
        }

        [HttpGet("get/{id}")]
        public Book GetBookById(int id)
        {
            return _bookService.GetBookById(id);
        }

        [HttpPost("add")]
        public Book AddBook(Book b)
        {
            return _bookService.AddBook(b);
        }

        [HttpPut("edit")]
        public Book UpdateBook(Book b)
        {
            return _bookService.UpdateBook(b);
        }

        [HttpDelete("delete/{id}")]
        public Book DeleteBook(int id)
        {
            return _bookService.DeleteBook(id);
        }

    }
}

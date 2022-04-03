using LibraryManagement.Models;
using LibraryManagement.Services;
using LibraryManagement.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{   [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    { 
        private readonly BooksService _bookService;

        public BooksController(BooksService bookService)
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

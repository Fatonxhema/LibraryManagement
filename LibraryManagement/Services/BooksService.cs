using LibraryManagement.DataContext;
using LibraryManagement.Models;
using LibraryManagement.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    public class BooksService : IBookService
    {
        private readonly LibraryContext _context;

        public BooksService(LibraryContext context)
        {
            _context = context;
        }

        public Book AddBook(Book book)
        {
            if(book != null)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return book;
            }
            return null;

        }

        public Book DeleteBook(int id)
        {
            var record = _context.Books.FirstOrDefault(book => book.Id == id);
            _context.Entry(record).State = EntityState.Deleted;
            _context.SaveChanges();
            return record;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var record = _context.Books.ToList();
            return record;
        }

        public Book GetBookById(int id)
        {
            var record = _context.Books.FirstOrDefault(book => book.Id == id);
            return record;
        }

        public Book UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();
            return book;
        }
    }
}

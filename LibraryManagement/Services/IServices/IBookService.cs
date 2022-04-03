using LibraryManagement.Models;
using System.Collections.Generic;


namespace LibraryManagement.Services.IServices
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();

        Book GetBookById(int id);

        Book AddBook(Book book);

        Book UpdateBook(Book book);

        Book DeleteBook(int id);
    }
}

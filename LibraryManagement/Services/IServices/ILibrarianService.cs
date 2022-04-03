using LibraryManagement.Models;
using System.Collections.Generic;


namespace LibraryManagement.Services.IServices
{
    public interface ILibrarianService
    {
        IEnumerable<Librarian> GetAllLibrarians();

        Librarian GetLibrarianById(int id);

        Librarian AddLibrarian(Librarian librarian);

        Librarian UpdateLibrarian(Librarian librarian);

        Librarian DeleteLibrarian(int id);
    }
}

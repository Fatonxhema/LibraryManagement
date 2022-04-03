using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

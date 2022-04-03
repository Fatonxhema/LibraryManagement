using LibraryManagement.DataContext;
using LibraryManagement.Models;
using LibraryManagement.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Services
{
    public class LibrariansService : ILibrarianService
    {
        private readonly LibraryContext _context;
        public LibrariansService(LibraryContext context)
        {
            _context = context;
        }

        public Librarian AddLibrarian(Librarian librarian)
        {
            if (librarian != null)
            {
                _context.Librarians.Add(librarian);
                _context.SaveChanges();
                return librarian;
            }
            return null;

        }

        public Librarian DeleteLibrarian(int id)
        {
            var record = _context.Librarians.FirstOrDefault(librarian => librarian.Id == id);
            _context.Entry(record).State = EntityState.Deleted;
            _context.SaveChanges();
            return record;
        }

        public IEnumerable<Librarian> GetAllLibrarians()
        {
            var record = _context.Librarians.ToList();
            return record;
        }

        public Librarian GetLibrarianById(int id)
        {
            var record = _context.Librarians.FirstOrDefault(librarian => librarian.Id == id);
            return record;
        }

        public Librarian UpdateLibrarian(Librarian librarian)
        {
            _context.Entry(librarian).State = EntityState.Modified;
            _context.SaveChanges();
            return librarian;
        }
    }
}

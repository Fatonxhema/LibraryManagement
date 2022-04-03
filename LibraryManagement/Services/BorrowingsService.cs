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
    public class BorrowingsService : IBorrowingService
    {
        private readonly LibraryContext _context;
        public BorrowingsService(LibraryContext context)
        {
            _context = context;
        }

        public Borrowing AddBorrowing(Borrowing borrowing)
        {
            if (borrowing != null)
            {
                _context.Borrowings.Add(borrowing);
                _context.SaveChanges();
                return borrowing;
            }
            return null;

        }

        public Borrowing DeleteBorrowing(int id)
        {
            var record = _context.Borrowings.FirstOrDefault(borrowing => borrowing.Id == id);
            _context.Entry(record).State = EntityState.Deleted;
            _context.SaveChanges();
            return record;
        }

        public IEnumerable<Borrowing> GetAllBorrowings()
        {
            var record = _context.Borrowings.ToList();
            return record;
        }

        public Borrowing GetBorrowingById(int id)
        {
            var record = _context.Borrowings.FirstOrDefault(borrowing => borrowing.Id == id);
            return record;
        }

        public Borrowing UpdateBorrowing(Borrowing borrowing)
        {
            _context.Entry(borrowing).State = EntityState.Modified;
            _context.SaveChanges();
            return borrowing;
        }
    }
}

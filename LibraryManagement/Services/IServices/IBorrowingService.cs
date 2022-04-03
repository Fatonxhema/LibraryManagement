using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Services.IServices
{
    public interface IBorrowingService
    {
        IEnumerable<Borrowing> GetAllBorrowings();

        Borrowing GetBorrowingById(int id);

        Borrowing AddBorrowing(Borrowing borrowing);

        Borrowing UpdateBorrowing(Borrowing borrowing);

        Borrowing DeleteBorrowing(int id);
    }
}

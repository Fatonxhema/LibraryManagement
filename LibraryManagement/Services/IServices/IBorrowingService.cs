using LibraryManagement.Models;
using System.Collections.Generic;


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

using LibraryManagement.Models;
using System.Collections.Generic;


namespace LibraryManagement.Services.IServices
{
    public interface ITransactionService
    {
        IEnumerable<Transaction> GetAllTransactions();

        Transaction GetTransactionById(int id);

        Transaction AddTransaction(Transaction u);

        Transaction UpdateTransaction(Transaction u);

        Transaction DeleteTransaction(int id);
    }
}

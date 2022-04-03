using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


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

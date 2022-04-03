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
    public class TransactionsService : ITransactionService
    {
        private readonly LibraryContext _context;
        public TransactionsService(LibraryContext context)
        {
            _context = context;
        }

        public Transaction AddTransaction(Transaction transaction)
        {
            if (transaction != null)
            {
                _context.Transactions.Add(transaction);
                _context.SaveChanges();
                return transaction;
            }
            return null;

        }

        public Transaction DeleteTransaction(int id)
        {
            var record = _context.Transactions.FirstOrDefault(transaction => transaction.Id == id);
            _context.Entry(record).State = EntityState.Deleted;
            _context.SaveChanges();
            return record;
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            var record = _context.Transactions.ToList();
            return record;
        }

        public Transaction GetTransactionById(int id)
        {
            var record = _context.Transactions.FirstOrDefault(transaction => transaction.Id == id);
            return record;
        }

        public Transaction UpdateTransaction(Transaction transaction)
        {
            _context.Entry(transaction).State = EntityState.Modified;
            _context.SaveChanges();
            return transaction;
        }
    }
}

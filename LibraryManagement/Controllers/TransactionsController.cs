using LibraryManagement.Models;
using LibraryManagement.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("getall")]
        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _transactionService.GetAllTransactions();
        }

        [HttpGet("get/{id}")]
        public Transaction GetTransactionById(int id)
        {
            return _transactionService.GetTransactionById(id);
        }

        [HttpPost("add")]
        public Transaction AddTransaction(Transaction trans)
        {
            return _transactionService.AddTransaction(trans);
        }

        [HttpPut("edit")]
        public Transaction UpdateTransaction(Transaction trans)
        {
            return _transactionService.UpdateTransaction(trans);
        }

        [HttpDelete("delete/{id}")]
        public Transaction DeleteTransaction(int id)
        {
            return _transactionService.DeleteTransaction(id);
        }
    }
}

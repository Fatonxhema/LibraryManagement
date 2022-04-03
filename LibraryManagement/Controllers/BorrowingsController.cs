using LibraryManagement.Models;
using LibraryManagement.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrowingsController : ControllerBase
    {
        private readonly IBorrowingService _borrowingService;

        public BorrowingsController(IBorrowingService borrowingService)
        {
            _borrowingService = borrowingService;
        }

        [HttpGet("getall")]
        public IEnumerable<Borrowing> GetAllBorrowings()
        {
            return _borrowingService.GetAllBorrowings();
        }

        [HttpGet("get/{id}")]
        public Borrowing GetBorrowingById(int id)
        {
            return _borrowingService.GetBorrowingById(id);
        }

        [HttpPost("add")]
        public Borrowing AddBorrowing(Borrowing b)
        {
            return _borrowingService.AddBorrowing(b);
        }

        [HttpPut("edit")]
        public Borrowing UpdateBorrowing(Borrowing b)
        {
            return _borrowingService.UpdateBorrowing(b);
        }

        [HttpDelete("delete/{id}")]
        public Borrowing DeleteBorrowing(int id)
        {
            return _borrowingService.DeleteBorrowing(id);
        }
    }
}

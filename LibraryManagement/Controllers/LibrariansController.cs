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
    public class LibrariansController : Controller
    {
        private readonly ILibrarianService _librarianService;

        public LibrariansController(ILibrarianService librarianService)
        {
            _librarianService = librarianService;
        }

        [HttpGet("getall")]
        public IEnumerable<Librarian> GetAllLibrarians()
        {
            return _librarianService.GetAllLibrarians();
        }

        [HttpGet("get/{id}")]
        public Librarian GetLibrarianById(int id)
        {
            return _librarianService.GetLibrarianById(id);
        }

        [HttpPost("add")]
        public Librarian AddLibrarian(Librarian l)
        {
            return _librarianService.AddLibrarian(l);
        }

        [HttpPut("edit")]
        public Librarian UpdateLibrarian(Librarian l)
        {
            return _librarianService.UpdateLibrarian(l);
        }

        [HttpDelete("delete/{id}")]
        public Librarian DeleteLibrarian(int id)
        {
            return _librarianService.DeleteLibrarian(id);
        }
    }
}

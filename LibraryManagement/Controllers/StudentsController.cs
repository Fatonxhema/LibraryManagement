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
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("getall")]
        public IEnumerable<Student> GetAllStudents()
        {
            return _studentService.GetAllStudents();
        }

        [HttpGet("get/{id}")]
        public Student GetStudentById(int id)
        {
            return _studentService.GetStudentById(id);
        }

        [HttpPost("add")]
        public Student AddStudent(Student u)
        {
            return _studentService.AddStudent(u);
        }

        [HttpPut("edit")]
        public Student UpdateStudent(Student u)
        {
            return _studentService.UpdateStudent(u);
        }

        [HttpDelete("delete/{id}")]
        public Student DeleteStudent(int id)
        {
            return _studentService.DeleteStudent(id);
        }
    }
}

using LibraryManagement.DataContext;
using LibraryManagement.Models;
using LibraryManagement.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Services
{
    public class StudentsService : IStudentService
    {
        private readonly LibraryContext _context;
        public StudentsService(LibraryContext context)
        {
            _context = context;
        }

        public Student AddStudent(Student student)
        {
            if (student != null)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return student;
            }
            return null;

        }

        public Student DeleteStudent(int id)
        {
            var record = _context.Students.FirstOrDefault(student => student.Id == id);
            _context.Entry(record).State = EntityState.Deleted;
            _context.SaveChanges();
            return record;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var record = _context.Students.ToList();
            return record;
        }

        public Student GetStudentById(int id)
        {
            var record = _context.Students.FirstOrDefault(student => student.Id == id);
            return record;
        }

        public Student UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            _context.SaveChanges();
            return student;
        }
    }
}

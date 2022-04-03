using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Services.IServices
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();

        Student GetStudentById(int id);

        Student AddStudent(Student student);

        Student UpdateStudent(Student student);

        Student DeleteStudent(int id);
    }
}

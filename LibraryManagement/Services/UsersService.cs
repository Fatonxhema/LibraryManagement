using LibraryManagement.DataContext;
using LibraryManagement.Models;
using LibraryManagement.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace LibraryManagement.Services
{
    public class UsersService : IUserService
    {
        private readonly LibraryContext _context;

        public UsersService(LibraryContext context)
        {
            _context = context;
        }

        public User AddUser(User users)
        {
            if (users != null)
            {
                _context.User.Add(users);
                _context.SaveChanges();
                return users;
            }
            return null;

        }

        public User DeleteUser(int id)
        {
            var record = _context.User.FirstOrDefault(x => x.Id == id);
            _context.Entry(record).State = EntityState.Deleted;
            _context.SaveChanges();
            return record;
        }

        public IEnumerable<User> GetAllUsers()
        {
            var record = _context.User.ToList();
            return record;
        }

        public User GetUserById(int id)
        {
            var record = _context.User.FirstOrDefault(x => x.Id == id);
            return record;
        }

        public User UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
            return user;
        }
    }
}

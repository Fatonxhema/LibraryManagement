using LibraryManagement.Models;
using System.Collections.Generic;


namespace LibraryManagement.Services.IServices
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();

        User GetUserById(int id);

        User AddUser(User u);

        User UpdateUser(User u);

        User DeleteUser(int id);
    }
}

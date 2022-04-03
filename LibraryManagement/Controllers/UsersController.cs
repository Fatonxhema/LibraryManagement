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
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IEnumerable<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("get/{id}")]
        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost("add")]
        public User AddUser(User u)
        {
            return _userService.AddUser(u);
        }

        [HttpPut("edit")]
        public User UpdateUser(User u)
        {
            return _userService.UpdateUser(u);
        }

        [HttpDelete("delete/{id}")]
        public User DeleteUser(int id)
        {
            return _userService.DeleteUser(id);
        }

    }
}

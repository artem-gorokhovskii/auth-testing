﻿using ASP_Test_3.Entity;
using ASP_Test_3.Service;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Test_3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public User[] GetUsersList()
        {
            UserService userService = new UserService();
            return userService.GetUsersList();
        }

        [HttpGet("{login}")]
        public User GetUser(string login)
        {
            UserService userService = new UserService();
            return userService.GetUser(login);
        }

        [HttpPost]
        public void AddUser([FromBody] User user)
        {
            UserService userService = new UserService();
            userService.AddUser(user);
        }

        [HttpDelete("{login}")]
        public bool RemoveUser(string login)
        {
            UserService userService = new UserService();
            try
            {
                userService.RemoveUser(login);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

using ASP_Test_3.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Test_3.Service
{
    interface IUserService
    {
        User[] GetUsersList();

        User GetUser(string login);

        void AddUser(User user);

        void RemoveUser(string login);
    }
}

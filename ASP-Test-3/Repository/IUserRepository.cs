using AuthTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTest.Repository
{
    interface IUserRepository
    {
        User[] GetUsersList();

        User GetUser(string login);

        void AddUser(User user);

        void RemoveUser(string login);
    }
}

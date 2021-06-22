using AuthTest.Entity;
using AuthTest.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace AuthTest.Repository
{
    public class UserRepository : IUserRepository
    {
        private static Dictionary<string, User> users = new Dictionary<string, User>() 
        {
            { "admin", new User("admin", "admin", "Artem", 26, Role.Admin) }
        };
        public void AddUser(User user)
        {
            if (users.ContainsKey(user.Login))
            {
                throw new RecordAlreadyExistsException("User already exists");
            }

            users.Add(user.Login, user);
        }

        public User GetUser(string login)
        {
            return users[login];
        }

        public User[] GetUsersList()
        {
            return users.Values.ToArray();
        }

        public void RemoveUser(string login)
        {
            if (!users.ContainsKey(login))
            {
                throw new RecordNotFoundException("User not found");
            }
            users.Remove(login);
        }
    }
}

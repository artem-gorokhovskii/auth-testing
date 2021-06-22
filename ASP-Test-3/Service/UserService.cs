using AuthTest.Entity;
using AuthTest.Exceptions;
using AuthTest.Repository;
using System;

namespace AuthTest.Service
{
    public class UserService : IUserService
    {
        public void AddUser(User user)
        {
            UserRepository userRepository = new UserRepository();
            userRepository.AddUser(user);
        }

        public User GetUser(string login)
        {
            UserRepository userRepository = new UserRepository();
            User user = userRepository.GetUser(login);
            if (user == null)
            {
                throw new RecordNotFoundException("User not found");
            }
            return user;
        }

        public User[] GetUsersList()
        {
            UserRepository userRepository = new UserRepository();
            return userRepository.GetUsersList();
        }

        public void RemoveUser(string login)
        {
            UserRepository userRepository = new UserRepository();
            userRepository.RemoveUser(login);
        }
    }
}

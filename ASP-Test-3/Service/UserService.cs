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
            try
            {
                return userRepository.GetUser(login);
            } catch
            {
                throw new RecordNotFoundException("User not found");
            }
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

using ShareNoteAppApi.Domain.Interfaces;
using ShareNoteAppApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser()
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserByAccountId(int accountId)
        {
            throw new NotImplementedException();
        }
    }
}

using ShareNoteAppApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Interfaces
{
    public interface IUserRepository
    {
        User CreateUser();
        User GetUser(int userId);
        List<User> GetAllUsers();
        User GetUserByAccountId(int accountId);
    }
}

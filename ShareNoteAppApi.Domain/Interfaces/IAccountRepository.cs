using ShareNoteAppApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Account CreateAccount();
        Account GetAccount(int id);
    }
}

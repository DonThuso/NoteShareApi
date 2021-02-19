using ShareNoteAppApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Interfaces
{
    public interface IAdministratorRepository
    {
        Administrator CreateAdministrator();
        Administrator GetAdministrator(int id);
        List<Administrator> GetAllAdministrastors();
    }
}

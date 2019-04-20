using Core.Entities.Authentication;
using Core.Entities.Login;
using Core.Repositories.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IAuthentication
    {
        Task<TeacherAccount> FindTeacherAccount(string userName, string password);
        Task<User> FindUserAccount(string userName, string password);
    }
}

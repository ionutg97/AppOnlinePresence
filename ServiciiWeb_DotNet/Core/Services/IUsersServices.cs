using Core.Entities.Attendance;
using Core.Entities.Login;
using Core.Repositories.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IUsersServices
    {
        Task<User> RegisterNewUserAsync(LoginDTO newUserAccount);
        Task<User> GetUserAsync(string UserName);
        Task<Attendance> PutAttendance(Attendance attendance);

    }
}

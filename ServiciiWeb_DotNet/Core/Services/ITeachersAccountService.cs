
using Core.Entities.Attendance;
using Core.Entities.Authentication;
using Core.Repositories.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ITeachersAccountService
    {
        Task<TeacherAccount> RegisterNewTeachersAsync(TeacherAccountDTO newTeacherAccount);
        Task<ListAttendances> CreateNewListAttendancesAsync(string ListName);
        Task<ListAttendances> GetListAttendanceByIdAsync(Guid id);
    }
}

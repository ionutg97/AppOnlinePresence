using Core.Entities.Attendance;
using Core.Entities.Login;
using Core.Repositories.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
   public interface IUsersRepository
    {
        Task Create(User user);
        Task<User> GetUserAsync(string UserName);
        Task<IEnumerable<TimetableDTO>> GetAllTimetables();
        Task<IEnumerable<TimetableDTO>> GetTimetables(string name);
        Task<IEnumerable<AttendanceDTO>> getOnlyOneAttendance(string name, string userName);
        Task Update(Attendance update);
        Task<Attendance> getAttendance(string name, string userName);
        Task<Attendance> getAttendanceById(Guid id);


    }
}

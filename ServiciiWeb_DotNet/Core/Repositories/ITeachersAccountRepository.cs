
using Core.Entities.Attendance;
using Core.Entities.Authentication;
using Core.Repositories.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface ITeachersAccountRepository
    {
        Task Create(TeacherAccount user);
        Task Create(ListAttendances listAttendances);
        Task<IEnumerable<AttendanceDTO>> getAllAttendances(string name);
        Task<ListAttendances> getListAttendanceById(Guid id);
        Task Delete(ListAttendances listA);
        

        //Task<IEnumerable<>>
    }
}

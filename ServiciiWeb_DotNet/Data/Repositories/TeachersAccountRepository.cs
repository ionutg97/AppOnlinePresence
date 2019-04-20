
using Core.Entities.Attendance;
using Core.Entities.Authentication;
using Core.Repositories;
using Core.Repositories.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class TeachersAccountRepository : ITeachersAccountRepository
    {
        private readonly AppDbContext context;

        public TeachersAccountRepository(AppDbContext context) : base()
        {
            this.context = context;
        }

        public async Task Create(TeacherAccount teacherAccount)
        {
            context.TeacherAccounts.Add(teacherAccount);
            context.SaveChanges();
        }

        public async Task Create(ListAttendances listAttendances)
        {
            context.ListAttendances.Add(listAttendances);
            context.SaveChanges();
        }

        public async Task Delete(ListAttendances listA)
        {
            context.ListAttendances.Remove(listA);
            context.SaveChanges();
        }


        public async Task<ListAttendances> getListAttendanceById(Guid id)
        {
            var attendance = context.ListAttendances
                .SingleOrDefault(s => s.Id == id);

            return attendance;
        }


        public async Task<IEnumerable<AttendanceDTO>> getAllAttendances(string name)
        {
            var listAttendance = await context.ListAttendances
                .Include(i => i.Attendances)
                .ThenInclude(t => t.Student)
                .FirstOrDefaultAsync(f => f.Name == name);

            return listAttendance.Attendances.Select(s => new AttendanceDTO()
            {
                StudentName = s.Student.Name,
                AttendaceName = name,
                Grade = s.Nota,
                TeacherNotification = s.TeacherNotification,
                StudentNotification = s.StudentNotification

            });
        }


    }
}

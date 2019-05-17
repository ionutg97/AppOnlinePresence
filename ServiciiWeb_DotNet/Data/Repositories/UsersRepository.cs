using Core.Entities.Login;
using Core.Repositories;
using Core.Repositories.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Authentication;
using Core.Entities.Attendance;

namespace Data.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext context;

        public UsersRepository(AppDbContext context) : base()
        {
            this.context = context;
        }

        public async Task Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }


        public async Task<IEnumerable<TimetableDTO>> GetAllTimetables()
        {
            var timetable = context.Timetables.Include(i => i.Laboratory).
                 Include(p => p.TeacherAccount).
                 Include(c => c.Classroom).
                 Include(cu => cu.Cours).
                 Select(t => new TimetableDTO()
                 {
                     HourStart = t.HourStart,
                     HourEnd = t.HourEnd,
                     Classroom = t.Classroom.Name,
                     Cours = t.Cours.Name,
                     Laboratory = t.Laboratory.Name,
                     TeacherName = t.TeacherAccount.TeacherFullName
                 });
            return timetable;
        }

        public async Task<IEnumerable<TimetableDTO>> GetTimetables(string name)
        {
            var timetable = context.Timetables.Include(i => i.Laboratory)
                 .Include(p => p.TeacherAccount)
                 .Include(c => c.Classroom)
                 .Include(cu => cu.Cours)
                 .Where(w => w.Cours.Name == name)
                 .Select(t => new TimetableDTO()
                 {
                     HourStart = t.HourStart,
                     HourEnd = t.HourEnd,
                     Classroom = t.Classroom.Name,
                     Cours = t.Cours.Name,
                     Laboratory = t.Laboratory.Name,
                     TeacherName = t.TeacherAccount.TeacherFullName
                 }).AsEnumerable();

            return timetable;
        }

        public async Task<User> GetUserAsync(string UserName)
        {
            var user = await context.Users.SingleOrDefaultAsync(u => u.UserName == UserName);
            return user;
        }

        public  async Task<Attendance> getAttendance(string name, string userName)
        {
            var listAttendance = await context.ListAttendances
                .Include(i => i.Attendances)
                .ThenInclude(t => t.Student)
                .FirstOrDefaultAsync(f => f.Name == name);

            var onlyOneAttendance = await listAttendance.Attendances.AsQueryable()
                .FirstOrDefaultAsync(w => w.Student.Name == userName);
            return onlyOneAttendance;
        }

        public async Task<IEnumerable<AttendanceDTO>> getOnlyOneAttendance(string name, string userName)
        {
            var listAttendance = await context.ListAttendances
                .Include(i => i.Attendances)
                .ThenInclude(t => t.Student)
                .FirstOrDefaultAsync(f => f.Name == name);

            var onlyOneAttendance = listAttendance.Attendances
                .Where(w => w.Student.Name == userName)
                .Select(s => new AttendanceDTO()
                {
                    StudentName = s.Student.Name,
                    AttendaceName = name,
                    Grade = s.Nota,
                    TeacherNotification = s.TeacherNotification,
                    StudentNotification = s.StudentNotification

                });
            return onlyOneAttendance;

        }

       public async Task Update(Attendance update)
        {
            context.Attendances.Update(update);
            context.SaveChanges();
        }

        public Task<Attendance> getAttendanceById(Guid id)
        {
            var attendance = context.Attendances
               .FirstOrDefaultAsync(f => f.Id == id);

            return attendance;

        }
    }
}

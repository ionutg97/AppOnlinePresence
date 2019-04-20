
using Core.Entities.Attendance;
using Core.Entities.Authentication;
using Core.Repositories;
using Core.Repositories.DTOs;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TeacherAccountService:ITeachersAccountService
    {
        ITeachersAccountRepository teachersAccountRepository;
        public TeacherAccountService(ITeachersAccountRepository teachersAccountRepository)
        {
            this.teachersAccountRepository = teachersAccountRepository;
        }

        public async Task<ListAttendances> CreateNewListAttendancesAsync(string ListName)
        {
            var newListAttendances = new ListAttendances
            {
                Id = Guid.NewGuid(),
                Name = ListName
            };

           await teachersAccountRepository.Create(newListAttendances);
            return newListAttendances;

        }


        public async Task<ListAttendances> GetListAttendanceByIdAsync(Guid id)
        {
            var listAttendance = await teachersAccountRepository.getListAttendanceById(id);
            if (listAttendance == null)
            {
                return null;
            }

            listAttendance.Name = $"{listAttendance.Name}";

            return listAttendance;


        }

        public async Task<TeacherAccount> RegisterNewTeachersAsync(TeacherAccountDTO newTeacherAccount)
        {
            TeacherAccount teacher = new TeacherAccount
            {
                Id = System.Guid.NewGuid(),
                TeacherAccountName = newTeacherAccount.TeacherAccountName,
                Password = newTeacherAccount.ConfirmPassword,
                TeacherFullName=newTeacherAccount.TeacherFullName

            };
            await teachersAccountRepository.Create(teacher);
            return teacher;
        }
    }
}

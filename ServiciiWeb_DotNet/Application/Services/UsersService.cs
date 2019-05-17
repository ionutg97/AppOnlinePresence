using Core.Entities.Attendance;
using Core.Entities.Login;
using Core.Repositories;
using Core.Repositories.DTOs;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UsersService : IUsersServices
    {
        IUsersRepository usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }


        public async Task<User> GetUserAsync(string UserName)
        {
            User user = await usersRepository.GetUserAsync(UserName);
            if (user == null)
                return null;
            else
                return user;
        }

        public async Task<Attendance> PutAttendance(Attendance attendance)
        {
            var newAttendance = await usersRepository.getAttendanceById(attendance.Id);
            if (newAttendance != null)
            {
                newAttendance.StudentNotification = attendance.StudentNotification;
                await usersRepository.Update(newAttendance);
                return newAttendance;
            }
           
                return null ;
        }

        async Task<User> IUsersServices.RegisterNewUserAsync(LoginDTO newUserAccount)
        {
            var user = await usersRepository.GetUserAsync(newUserAccount.UserName);
            if (user == null)
            {
                User newUser = new User
                {
                    Id = System.Guid.NewGuid(),
                    UserName = newUserAccount.UserName,
                    Password = newUserAccount.ConfirmPassword

                };
                await usersRepository.Create(newUser);
                return newUser;
            }
            else
            {
                return null;
            }
        }

    }
}

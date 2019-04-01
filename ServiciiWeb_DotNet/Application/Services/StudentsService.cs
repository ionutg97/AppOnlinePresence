using Core.Entities;
using Core.Repositories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class StudentsService : IStudentsService
    {
        IStudentsRepository studentsRepository;
        public StudentsService(IStudentsRepository studentsRepository)
        {
            this.studentsRepository = studentsRepository;
        }
        public Task<IEnumerable<Student>> GetAll()
        {
            return studentsRepository.GetAll();
        }

        public Task<Student> GetById(Guid Id)
        {
            return studentsRepository.GetById(Id);
        }
    }
}

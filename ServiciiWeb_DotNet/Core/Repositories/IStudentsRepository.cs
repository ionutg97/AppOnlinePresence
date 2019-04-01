using Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IStudentsRepository
    {
        Task<Student> GetById(Guid Id);
        Task<IEnumerable<Student>> GetAll();

    }
}

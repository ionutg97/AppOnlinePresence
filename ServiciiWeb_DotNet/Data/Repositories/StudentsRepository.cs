using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        private AppDbContext appDbContext;

        public StudentsRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await this.appDbContext.Students.ToListAsync();
        }

        public async Task<Student> GetById(Guid Id)
        {
            var result = await appDbContext.Students
                                     .FirstOrDefaultAsync(f => f.Id == Id);

            return result;
        }
    }
}

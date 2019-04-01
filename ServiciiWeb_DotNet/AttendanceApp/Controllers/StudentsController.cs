using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IStudentsService studentsService;
        public StudentsController(IStudentsService studentsService)
        {
            this.studentsService = studentsService;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAll()
        {
            var result = await studentsService.GetAll();

            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(Guid id)
        {
            var result = await studentsService.GetById(id);

            return Ok(result);
        }
    }
}

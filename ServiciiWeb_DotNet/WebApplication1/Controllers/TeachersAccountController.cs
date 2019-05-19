using Core.Entities.Authentication;
using Core.Repositories;
using Core.Repositories.DTOs;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{

    [Authorize(Policy = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersAccountController : ControllerBase
    {

        private readonly ITeachersAccountRepository teachersAccountRepository;
        private readonly ITeachersAccountService teacherAccountService;
        public TeachersAccountController(ITeachersAccountService teacherAccountService,
            ITeachersAccountRepository teachersAccountRepository)
        {
            this.teacherAccountService = teacherAccountService;
            this.teachersAccountRepository = teachersAccountRepository;
        }


        // GET api/teachersAccount/ name list of Attendance
        [HttpGet("{name}")]
        [ProducesResponseType(201, Type = typeof(TimetableDTO))]
        public async Task<IActionResult> GetListAttendance(string name)
        {
            var listAttendance = await teachersAccountRepository.getAllAttendances(name);
            if (listAttendance == null)
            {
                return BadRequest();
            }

            return Ok(listAttendance);
        }


        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(201, Type = typeof(TeacherAccount))]
        public async Task<IActionResult> CreateNewUserAccountAsync([FromBody] TeacherAccountDTO newTeacherAccount)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                TeacherAccount teacher = await teacherAccountService.RegisterNewTeachersAsync(newTeacherAccount);
                var uri = new Uri($"{Request.GetDisplayUrl()}/{teacher.Id}");

                return Created(uri, teacher);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // teacherAccount/ favorite name
        [HttpPut("{name}")]
        public async Task<IActionResult> PutNewList(string name)
        {
            var newListAttendance = await teacherAccountService.CreateNewListAttendancesAsync(name);

            if (newListAttendance == null)
            {
                return NotFound($"Attendance List with name {name} hasn't been created");
            }
            else
                return Ok(newListAttendance);
            //return NoContent();
        }

        // DELETE api/TeachersAccount/ GUID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListAttendance(Guid id)
        {
            var listAttendance = await teacherAccountService.GetListAttendanceByIdAsync(id);

            if (listAttendance == null)
            {
                return NotFound($"List Attendance with id {id} hasn't been found");
            }

           await teachersAccountRepository.Delete(listAttendance);
            return NoContent();

        }
    }
}

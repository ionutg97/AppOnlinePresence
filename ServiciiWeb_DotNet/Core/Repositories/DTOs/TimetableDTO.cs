using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Repositories.DTOs
{
    public class TimetableDTO
    {
        [Required(ErrorMessage = "The start hour can not be null")]
        [Display(Name = "start hour")]
        public DateTime HourStart { get; set; }

        [Required(ErrorMessage = "The end hour can not be null")]
        [Display(Name = "end hour")]
        public DateTime HourEnd { get; set; }

        [Required(ErrorMessage = "The teacher name can not be null")]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }

        [Required(ErrorMessage = "The Classroom name can not be null")]
        [Display(Name = "Classroom")]
        public string Classroom { get; set; }

      
        [Display(Name = "Cours")]
        public string Cours { get; set; }

        [Display(Name = "Laboratory")]
        public string Laboratory { get; set; }


    }
}

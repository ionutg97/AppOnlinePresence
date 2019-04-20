using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Repositories.DTOs
{
    public class AttendanceDTO
    {
        [Required(ErrorMessage = "The Attendace Name can not be null")]
        [Display(Name = "Attendance Name")]
        public String AttendaceName { get; set; }

        [Required(ErrorMessage = "The Student Name can not be null")]
        [Display(Name = "Student Name")]
        public String StudentName { get; set; }

        [Display(Name = "Grades")]
        public int Grade { get; set; }

        [Display(Name = "Teacher Notification")]
        public String TeacherNotification { get; set; }

        [Display(Name = "Student Notification")]
        public String StudentNotification { get; set; }




    }
}

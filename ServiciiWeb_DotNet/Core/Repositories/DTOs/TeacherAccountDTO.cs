using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Repositories.DTOs
{
    public class TeacherAccountDTO
    {
        [Required(ErrorMessage = "Teacher Name Account can not be null")]
        [Display(Name = "Teacher name Account")]
        public string TeacherAccountName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Teacher Full Name can not be null")]
        [Display(Name = "Teacher Full name")]
        public string TeacherFullName { get; set; }
    }
}

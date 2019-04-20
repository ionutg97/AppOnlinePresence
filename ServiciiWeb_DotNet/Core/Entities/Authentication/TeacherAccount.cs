using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities.Authentication
{
   public class TeacherAccount
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Teacher name account")]
        public string TeacherAccountName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Teacher full name")]
        public string TeacherFullName { get; set; }
    }
}

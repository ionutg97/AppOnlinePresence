using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Attendance
{
   public class ListAttendances
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Attendance> Attendances { get; set; }
    }
}

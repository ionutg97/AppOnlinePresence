using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Attendance
{
    public class Attendance
    {
        public Guid Id { get; set; }
        public int Nota { get; set; }
        public string TeacherNotification { get; set; }
        public string StudentNotification { get; set; }
        public Student Student { get; set; }

    }
}

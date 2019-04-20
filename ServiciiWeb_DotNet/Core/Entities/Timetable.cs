using Core.Entities.Authentication;
using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Timetable
    {
        public Guid Id { get; set; }
        public DateTime HourStart { get; set; }
        public DateTime HourEnd { get; set; }

        public TeacherAccount TeacherAccount { get; set; }
        public Cours Cours { get; set; }
        public Laboratory Laboratory { get; set; }
        public Classroom Classroom { get; set; }
    }
}

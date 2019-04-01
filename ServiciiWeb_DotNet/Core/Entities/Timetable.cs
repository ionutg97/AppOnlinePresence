using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Timetable
    {
        public Guid Id { get; set; }
        public DateTime HourStart { get; set; }
        public DateTime HourEnd { get; set; }

        public Professor Professor { get; set; }

        public Group Group { get; set; }

        public Cours Cours { get; set; }

        public Classroom Classroom { get; set; }

    }
}

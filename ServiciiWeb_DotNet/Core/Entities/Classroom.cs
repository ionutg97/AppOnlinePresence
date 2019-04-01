using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Classroom
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Timetable> Timetable { get; set; }
    }
}

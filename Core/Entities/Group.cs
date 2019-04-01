using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; }

        public List<Timetable> Timetable { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Cours
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Group> Groups { get; set; }
    }
}

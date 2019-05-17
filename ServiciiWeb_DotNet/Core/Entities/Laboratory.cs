using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Laboratory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Group Group { get; set; }
    }
}

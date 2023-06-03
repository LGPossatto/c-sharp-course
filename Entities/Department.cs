using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code.Entities
{
    public class Department
    {
        public string Name { get; private set; }

        public Department(string name)
        {
            Name = name;
        }
    }
}
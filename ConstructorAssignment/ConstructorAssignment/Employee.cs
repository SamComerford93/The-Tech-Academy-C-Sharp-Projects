using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Employee
    {
        // Chain two contructors together
        public Employee(string name) : this(name, "restricted")
        {
        }

        public Employee(string name, string access)
        {
            Name = name;
            Access = access;
        }

        public string Name { get; set; }
        public string Access { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Emplyee object
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            // Call the SayName() method
            employee.SayName();
        }
    }
}
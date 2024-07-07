using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            // Call super class method SayName()
            employee.SayName();
        }
    }
}
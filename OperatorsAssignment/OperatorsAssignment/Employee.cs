using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    // Create an Employee class
    public class Employee
    {
        // Create properties Id, FirstName and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == operator to compare if two Id's are the same
        public static bool operator == (Employee left, Employee right)
        {
            return (left.Id == right.Id);
        }

        // Overload != operator to compare if two Id's are the same
        public static bool operator != (Employee left, Employee right)
        {
            return (left.Id != right.Id);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating 3 employee objects to test methods
            Employee person1 = new Employee() { Id = 10, FirstName = "Sam", LastName = "Johnson" };
            Employee person2 = new Employee() { Id = 11, FirstName = "Bob", LastName = "Smith" };
            Employee person3 = new Employee() { Id = 11, FirstName = "Bob", LastName = "Smith" };

            // Test with differnt Id values
            Console.WriteLine(person1 == person2);
            Console.WriteLine(person1 != person2);

            // Test with same Id values
            Console.WriteLine(person2 == person3);
            Console.WriteLine(person2 != person3);
        }
    }
}
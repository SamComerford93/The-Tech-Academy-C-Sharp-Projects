using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        // Create Person class with two properties FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Create void method called SayName() that write full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

    }
}

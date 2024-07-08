using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Create a class called Employee and have it inherit from Person class
    // Inherit IQuittable interface
    public class Employee : Person, IQuittable
    {
        // Implement the SayName() method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        //Implement the Quit() method
        public void Quit()
        {
            Console.WriteLine("I Quit!");
        }
    }
}
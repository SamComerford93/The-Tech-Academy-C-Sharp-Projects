using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use polymorphism to create an object of IQuittable 
            IQuittable sam = new Employee();

            // Call the Quit() method
            sam.Quit();
        }
    }
}
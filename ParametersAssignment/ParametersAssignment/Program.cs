using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee with type string
            Employee<string> employee1 = new Employee<string>();
            employee1.things = new List<string>();
            // Assign a list of stings as the property value 
            employee1.things.Add("Uniform"); 
            employee1.things.Add("Tools");
            employee1.things.Add("Laptop");

            // Print list to console
            foreach (string item  in employee1.things)
            {
                Console.WriteLine(item);
            }

            // Instantiate Employee with type int
            Employee<int> employee2 = new Employee<int>();
            employee2.things = new List<int>();
            // Assign a list of integers as the property value 
            employee2.things.Add(12);
            employee2.things.Add(4);
            employee2.things.Add(1993);

            // Print list to console
            foreach (int item in employee2.things)
            {
                Console.WriteLine(item);
            }



        }
    }
}
using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable
            const string companyName = "SADCOM";

            
            Console.WriteLine("Welcome to {0}. Please enter your name:", companyName);
            // Create a variable using the var keyword. Takes a name from the user.
            var name = Console.ReadLine();

            Console.WriteLine("Do you know your access level? y or n");
            // Create a variable using the var keyword to check if the users knows their access level
            var knownAccess = Console.ReadLine().ToLower();

            // Used an if statment depending on if they know their access level
            if (knownAccess == "n")
            {
                Employee newEmployee = new Employee(name);
                Console.WriteLine("Welcome to {0} {1}. Your current access level is {2}.", companyName, newEmployee.Name, newEmployee.Access);
            }
            else
            {
                Console.WriteLine("Please enter your access level:");
                // Create a variable using the var keyword
                var access = Console.ReadLine();
                Employee newEmployee = new Employee(name, access);
                Console.WriteLine("Welcome to {0} {1}. Your current access level is {2}.", companyName, newEmployee.Name, newEmployee.Access);
            }


        }
    }
}
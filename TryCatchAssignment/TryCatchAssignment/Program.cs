using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age 
                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                // Throws an exception if a age is entered that is 0 or negative
                if (age <= 0)
                {
                    throw new ArgumentException();
                }

                // Display the year the user is born
                int currentYear = DateTime.Now.Year;
                int yearBorn = currentYear - age;
                Console.WriteLine(yearBorn);
            }
            // Display appropriate error message if the user enters zero or negative numbers
            catch (ArgumentException)
            {
                Console.WriteLine("You have entered an invalid age.");
                Console.ReadLine();
                return;
            }
            // Display a general message if an exception was caused by anything else
            catch (Exception)
            {
                Console.WriteLine("Error occurred. Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }


            

            
            

        }
    }
}
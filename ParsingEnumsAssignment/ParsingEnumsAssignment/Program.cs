using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isvalid = false;
            while (!isvalid)
            {
                // Wrap in a try/catch block
                try
                {
                    // Ask the user to eneter the current day
                    Console.WriteLine("Please enter the current day of the week:");
                    string enteredDay = Console.ReadLine();

                    // Assign the value to a variable of that enum data type
                    DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), enteredDay);
                    Console.WriteLine("Today is " + today);
                    Console.ReadLine();
                    isvalid = true;
                }

                catch (ArgumentException ex)
                {

                    // Print message if error occurs
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }  
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
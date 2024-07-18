using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            Console.WriteLine("The current date and time is {0}", DateTime.Now);

            // Ask the user to input a number
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            // Print the exact time it will be in (num) hours
            Console.WriteLine("The date and time in {0} hours will be {1}", num, DateTime.Now.AddHours(num));

        }
    }
}
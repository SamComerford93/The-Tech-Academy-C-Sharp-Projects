using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.WriteLine("Please enter an number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Log the number to a text file
            using (StreamWriter file = new StreamWriter(@"C:\Users\comesamw\logs\number.txt", true))
            {
                file.WriteLine(num);
            }

            // Print the text file back to the user
            using (StreamReader readFile = new StreamReader(@"C:\Users\comesamw\logs\number.txt"))
            {
                // create a line variable to assign one line at a time to from the text file
                string line;
                // use a while loop to print each line indiviually
                while ((line = readFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
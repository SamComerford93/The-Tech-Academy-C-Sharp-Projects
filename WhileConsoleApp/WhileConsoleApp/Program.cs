using System;

namespace WhileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // While statement
            // Count to 10 using a while loop
            // Create a variable called counter to track the number
            int counter = 0;

            // while counter is below 11 print the value of counter to the console and then add 1 to counter
            while (counter < 11)
            {
                Console.WriteLine(counter);
                counter++;
            }

            // Do While statement
            // Count down from 5 for launch
            // Create a variable for launch countdown
            int countdown = 5;
            do
            {
                Console.WriteLine("Blast off in... " + countdown);
                countdown--; // minus 1 from countdown
            }
            while (countdown > 0); // continue loop until 0 is reached
        }
    }
}
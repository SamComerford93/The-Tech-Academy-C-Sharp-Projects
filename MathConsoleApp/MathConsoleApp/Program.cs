using System;

namespace MathConsoleApp
{
    class program
    {
        static void Main(string[] args)
        {
            // Take in a number, multiply by 50 and print it to the console
            Console.WriteLine("Please enter a number!");
            string stringNum1 = Console.ReadLine();
            int num1 = Convert.ToInt32(stringNum1);
            int total1 = num1 * 50;
            Console.WriteLine(num1 + " multiplied by 50 = " + total1);

            // Take in a number, add 25 and print it to the console
            Console.WriteLine("Please enter a number!");
            string stringNum2 = Console.ReadLine();
            int num2 = Convert.ToInt32(stringNum2);
            int total2 = num2 + 25;
            Console.WriteLine(num2 + " plus 25 = " + total2);

            // Take in a number, divide by 12.5 and print it to the console
            Console.WriteLine("Please enter a number!");
            string stringNum3 = Console.ReadLine();
            double num3 = Convert.ToDouble(stringNum3);
            double total3 = num3 / 12.5;
            Console.WriteLine(num3 + " divided by 12.5 = " + total3);

            // Take in a number, check if greater than 50 and print true or false to the console
            Console.WriteLine("Please enter a number!");
            string stringNum4 = Console.ReadLine();
            int num4 = Convert.ToInt32(stringNum4);
            bool moreThan = num4 > 50;
            Console.WriteLine("Is " + num4 + " greater than 50: " + moreThan);

            // Take in a number, divide by 7 and print the remainder to the console
            Console.WriteLine("Please enter a number!");
            string stringNum5 = Console.ReadLine();
            int num5 = Convert.ToInt32(stringNum5);
            int remainder = num5 % 7;
            Console.WriteLine("The remainder of " + num5 + " divided by 7 is: " + remainder);
        }
    }
}
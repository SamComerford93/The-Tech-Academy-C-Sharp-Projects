using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            int num1 = 10;
            int num2 = 5;
            // Add
            Console.WriteLine(num1 + num2);
            // Subtract
            Console.WriteLine(num1 - num2);
            // Multiply
            Console.WriteLine(num1 * num2);
            // Divide
            Console.WriteLine(num1 / num2);
            // Modulo
            Console.WriteLine(num1 % num2);

            // Math operation on a string (string concatenation)
            string str1 = "Hello, ";
            string str2 = "Everybody!";
            Console.WriteLine(str1 + str2);

            // Addition
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);

            // Subtraction
            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());

            // Multiplication
            int product = 10 * 5;
            Console.WriteLine(product);

            // Division
            int quotient = 100 / 5;
            Console.WriteLine(quotient);

            // Modulus
            int remainder = 11 % 2;
            Console.WriteLine(remainder);

            // Greater or Less than
            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse.ToString());

            int roomTemperature = 70;
            int currentTemperature = 70;

            // Greater than or equal to
            // bool isWarm = currentTemperature >= roomTemperature;

            // Less than or equal to
            // bool isWarm = currentTemperature <= roomTemperature;

            // Equal to
            bool isWarm = currentTemperature == roomTemperature;

            // Not equal
            //bool isWarm = currentTemperature != roomTemperature;

            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
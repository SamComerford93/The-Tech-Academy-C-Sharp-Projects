using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Add a try block
        try
        {
            // Create a list of intergers
            List<int> numbers = new List<int>() { 4, 10, 25, 32, 40, 55 };

            // Ask user for a number
            Console.WriteLine("Please enter a number: ");
            int chosenNum = Convert.ToInt32(Console.ReadLine());

            // Write a loop that takes each interger and divides it by the entered number

            for (int i = 0; i < numbers.Count; i++)
            {
                int answer = numbers[i] / chosenNum;
                Console.WriteLine(numbers[i] + " divided by " + chosenNum + " equals " + answer);
            }
        }
        // Add a catch block
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number");
        }

        // Print a statement to show the program has continued after the try/catch block
        Console.WriteLine("This program has emerged from the try/catch block");
        
    }
}
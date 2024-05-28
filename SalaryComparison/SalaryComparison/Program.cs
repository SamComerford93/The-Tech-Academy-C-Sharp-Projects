using System;

namespace SalaryComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Print Person 1
            Console.WriteLine("Person 1");

            // Input person 1 hourly rate and convert to int and assign to rateP1
            Console.WriteLine("Hourly Rate?");
            string rateP1String = Console.ReadLine();
            int rateP1 = Convert.ToInt32(rateP1String);

            // Input person 1 hours worked per week and convert to int and assign to hoursP1
            Console.WriteLine("Hours worked per week?");
            string hoursP1String = Console.ReadLine();
            int hoursP1 = Convert.ToInt32(hoursP1String);

            // Print Person 2
            Console.WriteLine("Person 2");

            // Input person 2 hourly rate and convert to int and assign to rateP1
            Console.WriteLine("Hourly Rate?");
            string rateP2String = Console.ReadLine();
            int rateP2 = Convert.ToInt32(rateP2String);

            // Input person 2 hours worked per week and convert to int and assign to hoursP1
            Console.WriteLine("Hours worked per week?");
            string hoursP2String = Console.ReadLine();
            int hoursP2 = Convert.ToInt32(hoursP2String);

            // Work out annual salary of person 1 and assign to salaryP1 and print
            int salaryP1 = rateP1 * hoursP1 * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salaryP1);

            // Work out annual salary of person 2 and assign to salaryP1 and print
            int salaryP2 = rateP2 * hoursP2 * 52;
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salaryP2);

            // Check if person 1 makes more money than person 2 and print true or false
            bool moreMoney = salaryP1 > salaryP2;
            Console.WriteLine("Person 1 makes more money than Person 2:");
            Console.WriteLine(moreMoney);
        }
    }
}
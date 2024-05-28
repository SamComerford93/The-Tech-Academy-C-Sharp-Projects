using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            // input applicant age and convert to integer
            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            int age = Convert.ToInt32(ageString);

            // input if applicant has ever had DUI (true or false) and convert to boolean
            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\".");
            string duiString = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiString);

            // input how many speeding tickets applicant has and convert to int
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsString = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketsString);

            // check if applicant qualifies for insurance and assign answer to qualified
            bool qualified = (age > 15 && dui == false && tickets <= 3);

            // print result to console
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);

            Console.ReadLine();

        }
    }
}
using System;

namespace AcademyOfLearningCareerCollege
{
    class Program
    {
        static void Main()
        {
            //Print both titles
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");

            //Ask for students name and assign it to studentName
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            //Ask what course and assign it to course
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            //Ask for page number and assign it to pageString and then covnert to interger assigned to pageNum
            Console.WriteLine("What page number?");
            string pageString = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageString);

            //Ask if help is required (true or false) and assign this to requiresHelp as a bool
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpString = Console.ReadLine();
            bool requiresHelp = Convert.ToBoolean(helpString);

            //Ask about positive experiences and assign answer to positiveExperiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            //Ask about any other feedback and assign answer to feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //Ask how many hours studied and assign answer to hoursStudied
            Console.WriteLine("How many hours did you study today?");
            string hoursString = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hoursString);

            // Print closing statement
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");

        }
    }
}
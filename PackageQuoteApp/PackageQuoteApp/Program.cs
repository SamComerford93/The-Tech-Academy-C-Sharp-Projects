using System;

namespace PackageQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructons below.");

            // Ask user for package weight and convert to an integer
            Console.WriteLine("Please enter the package weight:");
            string weightString = Console.ReadLine();
            int weight = Convert.ToInt32(weightString);

            // Check if weight is greater than 50 and if true display error and end program.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Ask user for dimensions of package and convert to integer
            Console.WriteLine("Please enter the package width:");
            string widthString = Console.ReadLine();
            int width = Convert.ToInt32(widthString);

            Console.WriteLine("Please enter the package height:");
            string heightString = Console.ReadLine();
            int height = Convert.ToInt32(heightString);

            Console.WriteLine("Please enter the package length:");
            string lengthString = Console.ReadLine();
            int length = Convert.ToInt32(lengthString);

            // Check if total of dimensions is greater than 50 and if true display error and end program.
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                return;
            }

            // Work out quote by multiplying all dimensions and weight together and divide by 100.
            int quote = (weight * width * height * length) / 100;

            // Display the quote to the user as a dollar amount
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
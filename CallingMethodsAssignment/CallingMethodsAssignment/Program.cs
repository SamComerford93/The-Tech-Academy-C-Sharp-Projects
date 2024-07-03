using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for a number to use add method
            Console.WriteLine("Please enter a number to add to: ");
            int addNum = Convert.ToInt32(Console.ReadLine());
            // Use add method to add 10 to inputted number
            int addAnswer = MathMethods.AddTen(addNum);
            // Print answer to console
            Console.WriteLine(addNum + " plus 10 equals " + addAnswer);

            // Ask user for a number to use multiplication method
            Console.WriteLine("Please enter a number to multiply: ");
            int timesNum = Convert.ToInt32(Console.ReadLine());
            // Use multiply method to multiply inputted number by 3
            int timesAnswer = MathMethods.MultiplyByThree(timesNum);
            // Print answer to console
            Console.WriteLine(timesNum + " multipled by 3 equals " + timesAnswer);

            // Ask user for a number to use minus method
            Console.WriteLine("Please enter a number to minus from: ");
            int minusNum = Convert.ToInt32(Console.ReadLine());
            // Use minus method take away 50 from inputted number
            int minusAnswer = MathMethods.MinusFifty(minusNum);
            // Print answer to console
            Console.WriteLine(minusNum + " minus 50 equals " + minusAnswer);
        }
    }
}
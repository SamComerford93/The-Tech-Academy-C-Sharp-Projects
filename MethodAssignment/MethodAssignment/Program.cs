using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathMethods Math1 = new MathMethods();

            // Ask the user to input a number
            Console.WriteLine("Please enter a number: ");
            int pickNum1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to pick a second number but it is optional
            Console.WriteLine("Please enter another number if you want. If not please press enter.");
            try
            {
                int pickNum2 = Convert.ToInt32(Console.ReadLine());
                // Call method passing in both integers
                int answer = Math1.MathOp(pickNum1, pickNum2);
                Console.WriteLine(pickNum1 + " multipled by " + pickNum2 + " multipled by 3 equals " + answer);
            }
            catch
            {
                // Call method passing in just the first integer
                int answer = Math1.MathOp(pickNum1);
                Console.WriteLine(pickNum1 + " multipled by 1 multipled by 3 equals " + answer);
            }
            

            Console.ReadLine();
        }
    }
}

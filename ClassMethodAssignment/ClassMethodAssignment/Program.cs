using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Instantiate the class
            MathMethod math = new MathMethod();

            // Ask for the use to input a number
            Console.WriteLine("Please enter a number:");
            // Convert string input to integer
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            // Call method and display intger divided by 2
            math.DivideByTwo(userNum1);

            // Call a method with output parameters
            Console.WriteLine("Please enter a number:");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            int doubled;
            math.MultiplyByTwo(userNum2, out doubled);
            Console.WriteLine(doubled);

            // Overload a method
            Console.WriteLine("Please enter a decimal number:");
            float userNum3 = float.Parse(Console.ReadLine());
            float doubledDecimal;
            math.MultiplyByTwo(userNum3, out doubledDecimal);
            Console.WriteLine(doubledDecimal);

            // Call the method of a static class
            StaticClass.StaticMethod();


        }
    }
}
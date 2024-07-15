using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        // Create a Struct called Number
        public struct Number
        {
            // Create a property call Amount of data type decimal
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            // Create an object of data type Number
            Number money = new Number();
            // Assign an amount to it
            money.Amount = 30.50m;

            // Print the amount to console
            Console.WriteLine("I have £" + money.Amount.ToString());
            Console.ReadLine();
        }
    }
}
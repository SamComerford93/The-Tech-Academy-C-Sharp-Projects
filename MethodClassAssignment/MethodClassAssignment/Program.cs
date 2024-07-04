using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            DisplayMath numbers = new DisplayMath();

            // Call the method passing in two numbers
            numbers.TwoNums(12, 15);

            // Call the method specifying the parameters by name
            numbers.TwoNums(num1: 20, num2: 30);
        }
    }
}
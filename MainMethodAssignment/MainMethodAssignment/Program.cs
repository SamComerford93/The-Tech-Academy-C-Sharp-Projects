using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations math1 = new MathOperations();

            // Call method passing in an integer
            Console.WriteLine(math1.ChangeNum(34));

            // Call method passing in a decimal 
            Console.WriteLine(math1.ChangeNum(14.7m));

            // Call method passing in a string
            Console.WriteLine(math1.ChangeNum("16"));
        }
    }
}
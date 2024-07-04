using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class DisplayMath
    {
        // Create a void method that does a math operation to the first integer and displays the second
        public void TwoNums(int num1, int num2)
        {
            // Added 10 to the first intger passed in
            num1 = num1 + 10;
            // Displayed the second integer passed in
            Console.WriteLine(num2);
        }
    }
}

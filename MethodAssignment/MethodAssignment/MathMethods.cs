using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class MathMethods
    {
        // Create a method that takes in two intgers but the second one is optional
        public int MathOp(int num1, int num2 = 1)
        {
            return num1 * num2 * 3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathMethods
    {
        // Created a method to add 10 to a number
        public static int AddTen(int num)
        {
            int addTotal = num + 10;
            return addTotal;
        }

        // Created a method to multiply a number by 3
        public static int MultiplyByThree(int num)
        {
            int multiplyTotal = num * 3;
            return multiplyTotal;
        }

        // Created a method to take away 50 from a number
        public static int MinusFifty(int num)
        {
            int minusTotal = num - 50;
            return minusTotal;
        }
    }
}

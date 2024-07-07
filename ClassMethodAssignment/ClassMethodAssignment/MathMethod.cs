using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class MathMethod
    {
        // Create a void method that takes a number and divides it by 2
        public void DivideByTwo(int num)
        {
            int halfNum = num / 2;
            Console.WriteLine(halfNum);
        }

        //public void DivideByTwo(int num)
        //{
        //    int value;
        //    Output(num, out value);

        //    Console.WriteLine(value);
        //}

        // Create a method with output parameters
        public void MultiplyByTwo(int num, out int result)
        {
            result = num * 2;
        }

        // Overload a method
        public void MultiplyByTwo(float num, out float result)
        {
            result = num * 2;
        }

    }
}

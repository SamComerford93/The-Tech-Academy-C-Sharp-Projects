using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathOperations
    {
        // Create a method that takes in an integer
        public int ChangeNum(int num)
        {
            return num + 8;
        }

        // Create a method that takes in a decimal
        public int ChangeNum(decimal num)
        {
            // Convert the decimal into a int
            int wholeNum = Convert.ToInt32(num);
            return wholeNum * 10;
        }
        
        // Create a method that takes in a string
        public int ChangeNum(string num)
        {
            // Convert string to int 
            int wholeNum = Convert.ToInt32(num);
            return wholeNum - 13;
        }
    }
}

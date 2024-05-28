using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND (&&) Operator
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            // OR (||) Operator
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            // EQUAL (==) Operator
            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);

            // NOT EQUAL (!=) Operator
            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);

            // XOR (^) Operator
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            Console.ReadLine();
        }
    }
}
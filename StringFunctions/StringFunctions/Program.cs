using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab";
            //string fileName = "C:\\Users\\Jesse";
            //string fileName2 = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //bool trueOrFalse2 = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");


            Console.WriteLine(sb);  
        }
    }
}
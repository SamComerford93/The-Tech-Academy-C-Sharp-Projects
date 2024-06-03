using System;
using System.Text;

namespace StringConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 3 strings
            string start = "Hello, ";
            string name = "Sam";
            string end = ". Welcome to this app!";

            // Concatenate all 3 strings to make a sentence
            string fullSentence = start + name + end;
            Console.WriteLine(fullSentence);

            // Convert a string to uppercase
            string nameCaps = name.ToUpper();
            Console.WriteLine(nameCaps);

            // Create a Stringbuilder
            StringBuilder paragraph = new StringBuilder();

            // Create a paragraph by adding one sentence at a time
            paragraph.Append("The rain was coming. ");
            paragraph.Append("Everyone thought this would be a good thing. ");
            paragraph.Append("It hadn't rained in months and the earth was dry as a bone. ");
            paragraph.Append("It wasn't a surprise that everyone thought a good rain was what was needed, but they never expected how much rain would actually arrive.");

            Console.WriteLine(paragraph);

        }
    }
}
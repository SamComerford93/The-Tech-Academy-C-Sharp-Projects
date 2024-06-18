using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Created an array of strings
        string[] stringArray = { "Red", "Blue", "Green", "Yellow", "Pink", "Purple", "Black", "White" };

        // Ask for user to pick an index
        Console.WriteLine("Select a number between 0 and 7:");
        int index1 = Int32.Parse(Console.ReadLine());
        
        // If statement to check if index is valid and then print the item if true
        // If false print an error message
        if (index1 >= 0 && index1 <= 7 )
        {
            Console.WriteLine(stringArray[index1]);
        }
        else
        {

            Console.WriteLine("The index you have selected is not valid!");
            
        }

        // Created an array of integers
        int[] intArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        // Ask for user to pick an index
        Console.WriteLine("Select a number between 0 and 9:");
        int index2 = Int32.Parse(Console.ReadLine());

        // If statement to check if index is valid and then print the item if true
        // If false print an error message
        if (index2 >= 0 && index2 <= 9)
        {
            Console.WriteLine(intArray[index2]);
        }
        else
        {

            Console.WriteLine("The index you have selected is not valid!");

        }

        // Created a list and added some strings to populate the list
        List<string> stringList = new List<string>();

        stringList.Add("First");
        stringList.Add("Second");
        stringList.Add("Third");
        stringList.Add("Fourth");
        stringList.Add("Fifth");

        // Ask for user to pick an index
        Console.WriteLine("Select a number between 0 and 4:");
        int index3 = Int32.Parse(Console.ReadLine());

        // If statement to check if index is valid and then print the item if true
        // If false print an error message
        if (index3 >= 0 && index3 <= 4)
        {
            Console.WriteLine(stringList[index3]);
        }
        else
        {

            Console.WriteLine("The index you have selected is not valid!");

        }


    }
 }
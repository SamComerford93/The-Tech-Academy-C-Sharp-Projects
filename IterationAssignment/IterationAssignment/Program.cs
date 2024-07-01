using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Assignment Part 1
        // Create an array of strings

        string[] Greetings = { "Hello", "Hi", "Good Morning", "Good Afternoon" };

        // Ask user to input a name and assign it to name
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        // Loop through array and add name to the end of each string
        for (int i = 0; i < Greetings.Length; i++)
        {
            Greetings[i] = Greetings[i] + " " + name;
        }

        // Loop to print of each string in the array
        for (int i = 0; i < Greetings.Length; i++)
        {
            Console.WriteLine(Greetings[i]);
        }

        // Assignment Part 2
        // Create an infinite loop
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        // The end point of the loop was set to i < 0. but due to i starting at 0 and incrementing by 1 this would cause an inifite loop
        // I have change i < 0 to i < 10 which now prints the numbers from 0 to 9

        // Assignment Part 3
        // Create a loop using < operator
        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine("Number: " + i);
        }

        // Create a loop using <= operator
        for (int i = 90; i <= 100; i++)
        {
            Console.WriteLine(i);
        }

        // Assignment Part 4
        // Create list of unique strings
        List<string> colours = new List<string>() { "red", "blue", "green", "yellow", "pink", "black", "white" };

        // Ask for user input to search list
        Console.WriteLine("Please enter a colour: ");
        string colourPick = Console.ReadLine();

        // Create a loop that iterates through the list and displays the index of the list item
        for (int i = 0; i < colours.Count; i++)
        {
            // Add code to check if input is contained within the list
            if (colours.Contains(colourPick) == false)
            {
                Console.WriteLine("This colour is not contained in this list!");
                break;
            }
            else if (colours[i] == colourPick)
            {
                Console.WriteLine("This color can be found at index: " + i);
                // Add code to stop the loop once match has been found
                break;
            }
            else
            {
                continue;
            }
        }

        // Assignment Part 5
        // Create a list of strings that has two identical strings
        List<string> names = new List<string>() { "John", "Andy", "Mark", "John", "Peter" };

        // Ask for user input to search list
        Console.WriteLine("Please enter a name: ");
        string namePick = Console.ReadLine();

        // Create a loop that iterates through the list and displays the index of the list item
        for (int i = 0; i < names.Count; i++)
        {
            // Add code to check if input is contained within the list
            if (!names.Contains(namePick))
            {
                Console.WriteLine("This name is not contained in this list!");
                break;
            }
            else if (names[i] == namePick)
            {
                Console.WriteLine("This name can be found at index: " + i);
            }
            else
            {
                continue;
            }
        }

        // Assignment Part 6 
        // Create a list of strings that has two identical strings
        List<string> animals = new List<string>() { "Lion", "Elephant", "Cow", "Bear", "Elephant", "Pig", "Sheep" };

        // Create a foreach loop that will print if each item is unique or is a duplicate in the list
        List<string> listOfAnimals = new List<string>(); // created a list to store animals that have been checked

        foreach (string animal in animals)
        {
            if (!listOfAnimals.Contains(animal))
            {
                Console.WriteLine(animal + " - this animal is unique");
                listOfAnimals.Add(animal); // adds animal to list to check for duplicates
            }
            else if (listOfAnimals.Contains(animal))
            {
                Console.WriteLine(animal + " - this animal is a duplicate");
            }
        }
    }
}
using ParsingEnumsAssignment;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System;

namespace ParsingEnumsAssignment
{
    // Define an enum to represent the days of the week
    // Enums are strongly typed constants that make code more readable
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week (e.g., Monday):");

            // Read the user input as a string
            string userInput = Console.ReadLine();

            try
            {
                // Attempt to parse the user input into the DaysOfWeek enum
                // The 'true' parameter makes parsing case-insensitive
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // If parsing succeeds, display the parsed enum value
                Console.WriteLine("You entered: " + currentDay);
            }
            catch (Exception)
            {
                // If parsing fails (invalid input), display an error message
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
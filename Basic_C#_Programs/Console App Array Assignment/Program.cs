using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colorArray =
                { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown" };
            int colorSelect;
            PromptForIndex("Select a number between 0 and 9 for your favorite color: ",
                           colorArray.Length, out colorSelect);
            Console.WriteLine("Your favorite color is: " + colorArray[colorSelect]);

            List<string> occupationList = new List<string>
            {
                "Doctor", "Lawyer", "Engineer", "Teacher", "Artist",
                "Scientist", "Chef", "Pilot", "Musician", "Athlete"
            };
            int listSelect;
            PromptForIndex("Select a number between 0 and 9 for your new occupation: ",
                           occupationList.Count, out listSelect);
            Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
        }

        static void PromptForIndex(string message, int maxCount, out int selection)
        {
            selection = -1;
            bool valid = false;
            while (!valid)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (!int.TryParse(input, out selection))
                {
                    Console.WriteLine("Invalid format. Please enter a whole number.");
                }
                else if (selection < 0 || selection >= maxCount)
                {
                    Console.WriteLine($"Out of range. Please choose 0 through {maxCount - 1}.");
                }
                else
                {
                    valid = true;
                }
            }
        }
    }
}


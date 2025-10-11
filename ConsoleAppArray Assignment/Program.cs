using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of strings
            string[] colorArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown" };
            // Ask the user to display the string at that index
            Console.WriteLine("Please select another number between 0 and 9:");
            bool validResult = false;

            while (!validResult)
            {
                try
                {
                    Console.WriteLine("Your favorite color is: " + colorArray[Convert.ToInt32(Console.ReadLine())]);
                    validResult = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Select a number between 0 and 9.");
                }
            }

            // List of strings
            List<string> occupationList = new List<string>()
            {
                "Cashier",
                "Designer",
                "Architect",
                "Pilot",
                "Engineer",
                "Software Developer",
                "QA Tester"
            };
            // Ask the user to display the string at that index
            Console.WriteLine("Please select another number between 0 and 6:");
            validResult = false;

            while (!validResult)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[Convert.ToInt32(Console.ReadLine())]);
                    validResult = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Select a number between 0 and 6.");
                }
            }
        }
    }
}
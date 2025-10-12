using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            // DateTime.Now retrieves the system's current date and time
            Console.WriteLine("The current date and time is: " + DateTime.Now);

            // Ask the user to enter a number
            Console.WriteLine("Please enter a number of hours:");

            // Read the user input as a string
            string input = Console.ReadLine();

            // Convert the string input into an integer
            // This assumes the user enters a valid number
            int hours = Convert.ToInt32(input);

            // Add the entered number of hours to the current time
            // DateTime.AddHours() returns a new DateTime object with the added hours
            DateTime futureTime = DateTime.Now.AddHours(hours);

            // Print the result to the console
            Console.WriteLine("In " + hours + " hours, the exact date and time will be: " + futureTime);

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}

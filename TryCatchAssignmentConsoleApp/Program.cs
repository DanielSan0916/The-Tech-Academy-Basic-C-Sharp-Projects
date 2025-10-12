using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their age
            Console.WriteLine("Please enter your age:");

            try
            {
                // Read the user input as a string
                string input = Console.ReadLine();

                // Convert the string input into an integer
                int age = Convert.ToInt32(input);

                // Check if the user entered zero or a negative number
                if (age <= 0)
                {
                    // Throw an exception if the age is invalid
                    throw new ArgumentOutOfRangeException("Age must be greater than zero.");
                }

                // Calculate the year of birth
                // DateTime.Now.Year gets the current year
                int birthYear = DateTime.Now.Year - age;

                // Display the year the user was born
                Console.WriteLine("You were born in the year: " + birthYear);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Handle the case where the user entered zero or a negative number
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                // Handle the case where the user input could not be converted to an integer
                Console.WriteLine("Error: Please enter a valid number for your age.");
            }
            catch (Exception)
            {
                // Handle any other unexpected exceptions
                Console.WriteLine("An unexpected error occurred. Please try again.");
            }

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}

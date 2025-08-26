using System;  // Imports the System namespace, which contains fundamental classes like Console

namespace MathAndComparisonOperators  // Defines a namespace to organize related classes
{
    class Program  // Declares the Program class that contains the application's entry point
    {
        static void Main(string[] args)  // Entry point of the application; args can receive command-line parameters
        {
            // Display the title of the program
            Console.WriteLine("Anonymous Income Comparison Program");

            // ----- Person 1 Input -----
            Console.WriteLine("Person 1");                // Indicates we’re collecting data for the first person
            Console.WriteLine("Hourly Rate?");            // Prompt user for Person 1’s hourly rate
            string hourlyRate1 = Console.ReadLine();     // Read the user input as a string

            Console.WriteLine("Hours worked per week?");  // Prompt user for Person 1’s weekly hours
            string hours1 = Console.ReadLine();          // Read the user input as a string

            // Convert the string inputs to integers and calculate weekly salary
            int salary1 = Convert.ToInt32(hourlyRate1)   // Convert hourly rate to int
                          * Convert.ToInt32(hours1);     // Convert weekly hours to int and multiply

            // ----- Person 2 Input -----
            Console.WriteLine("Person 2");                // Indicates we’re collecting data for the second person
            Console.WriteLine("Hourly Rate?");            // Prompt user for Person 2’s hourly rate
            string hourlyRate2 = Console.ReadLine();     // Read the user input as a string

            Console.WriteLine("Hours worked per week?");  // Prompt user for Person 2’s weekly hours
            string hours2 = Console.ReadLine();          // Read the user input as a string

            // Convert the string inputs to integers and calculate weekly salary
            int salary2 = Convert.ToInt32(hourlyRate2)   // Convert hourly rate to int
                          * Convert.ToInt32(hours2);     // Convert weekly hours to int and multiply

            // ----- Annual Salary Output -----
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1 * 52);             // Multiply weekly salary by 52 weeks and display

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2 * 52);             // Multiply weekly salary by 52 weeks and display

            // ----- Comparison -----
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = salary1 > salary2;             // Compare weekly salaries and store result
            Console.WriteLine(isMore);                   // Print True if Person 1’s salary is higher, otherwise False

            Console.ReadLine();  // Wait for user to press Enter before closing the console window
        }
    }
}
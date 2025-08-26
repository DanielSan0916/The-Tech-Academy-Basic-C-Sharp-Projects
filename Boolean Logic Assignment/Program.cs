using System;  // Brings core .NET types into scope, including Console

namespace BooleanLogic  // Groups related classes under a single logical name
{
    class Program  // Defines the Program class, which holds the Main entry point
    {
        static void Main(string[] args)  // Application entry point; args holds any command-line parameters
        {
            // Display the application header
            Console.WriteLine("Car Insurance Application");

            // Prompt for and read the applicant's age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            // - Read line as string
            // - Convert the string to an integer
            // - Store the result in the variable 'age'

            // Ask whether the applicant has ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine()
                                .ToLower();
            // - Read the raw input
            // - Convert it to lowercase so that "YES", "Yes", "yes" are all handled the same

            bool dui = answer == "yes";
            // - Evaluate whether the cleaned-up answer equals "yes"
            // - Assign true if they answered "yes", false otherwise

            // Prompt for and read how many speeding tickets the applicant has
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            // - Convert the input string to an integer and store in 'tickets'

            // Evaluate qualification criteria:
            // 1. Applicant must be older than 15
            // 2. Applicant must not have a DUI
            // 3. Applicant must have 3 or fewer speeding tickets
            Console.WriteLine("Qualified for insurance?");
            bool qualified = (age > 15)    // true only if age > 15
                             && !dui        // and they have never had a DUI
                             && (tickets <= 3);
            // - Combine three boolean expressions with logical AND

            // Output the boolean result (true or false)
            Console.WriteLine(qualified);
        }
    }
}
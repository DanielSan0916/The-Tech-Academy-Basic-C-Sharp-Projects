using System;  

namespace PackageExpressQuote  // Defines a namespace for organizing related classes
{
    class Program  // Declares the Program class containing the application entry point
    {
        static void Main(string[] args)  // Main method: the application’s starting point
        {
            // 1. Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. Prompt for package weight
            Console.Write("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            //    - Read user input as string
            //    - Convert the string to an integer and store in 'weight'

            // 3. Check if weight exceeds allowed maximum
            if (weight > 50)
            {
                // If too heavy, show error and end program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // 4. Prompt for package width
            Console.Write("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            //    - Read and convert width to integer

            // 5. Prompt for package height
            Console.Write("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            //    - Read and convert height to integer

            // 6. Prompt for package length
            Console.Write("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            //    - Read and convert length to integer

            // 7. Check if combined dimensions exceed allowed maximum
            if (width + height + length > 50)
            {
                // If too big, show error and end program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // 8. Compute the shipping quote
            //    - First calculate volume: width × height × length
            int volume = width * height * length;

            //    - Then multiply by weight
            //    - Finally divide by 100 to get the quote
            decimal quote = volume * weight / 100m;
            //    - Use decimal and 100m for precise monetary calculation

            // 9. Display the quote formatted as currency
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

            // 10. Thank the user
            Console.WriteLine("Thank you!");
        }
    }
}
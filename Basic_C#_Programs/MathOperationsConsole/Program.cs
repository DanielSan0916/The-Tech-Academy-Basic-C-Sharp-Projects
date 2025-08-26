using System;                         // Import core library for console I/O

namespace MathOperationsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Multiply input by 50
            Console.Write("Enter a number to multiply by 50: ");
            long input1 = Convert.ToInt64(Console.ReadLine());   // Accept large values
            long result1 = input1 * 50;
            Console.WriteLine($"Result: {result1}\n");

            // 2. Add 25 to input
            Console.Write("Enter a number to add 25: ");
            long input2 = Convert.ToInt64(Console.ReadLine());
            long result2 = input2 + 25;
            Console.WriteLine($"Result: {result2}\n");

            // 3. Divide input by 12.5
            Console.Write("Enter a number to divide by 12.5: ");
            double input3 = Convert.ToDouble(Console.ReadLine());
            double result3 = input3 / 12.5;
            Console.WriteLine($"Result: {result3}\n");

            // 4. Check if input is greater than 50
            Console.Write("Enter a number to check > 50: ");
            double input4 = Convert.ToDouble(Console.ReadLine());
            bool isGreater = input4 > 50;
            Console.WriteLine($"Greater than 50? {isGreater}\n");

            // 5. Remainder when dividing input by 7
            Console.Write("Enter a number to get remainder of division by 7: ");
            long input5 = Convert.ToInt64(Console.ReadLine());
            long remainder = input5 % 7;
            Console.WriteLine($"Remainder: {remainder}\n");

            // Pause so console stays open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
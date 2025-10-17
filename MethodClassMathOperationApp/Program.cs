using System;

namespace MathOperationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method with positional arguments
            mathOps.DoMath(5, 10);

            // Call the method with named arguments
            mathOps.DoMath(firstNumber: 7, secondNumber: 20);

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
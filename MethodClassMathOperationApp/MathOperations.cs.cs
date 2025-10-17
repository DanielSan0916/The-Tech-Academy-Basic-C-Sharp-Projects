using System;  // Needed for Console

namespace MathOperationApp
{
    // This class contains our math method
    public class MathOperations
    {
        // A void method that takes two integers
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first number
            int result = firstNumber * 2;

            // Display the result of the math operation
            Console.WriteLine("The result of the math operation on the first number is: " + result);

            // Display the second number directly
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }
}
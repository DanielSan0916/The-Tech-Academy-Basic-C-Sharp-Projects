using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Create a list of integers
        List<int> intList = new List<int>() { 5, 99, 23, 18, 22, 12, 2994, 101, 7700 };
        //Ask the user for input and loop through the list dividing each number by the input
        bool numValid = false;
        while (!numValid)
        {
            //Using a try/catch block to give error message
            try
            { 
                Console.WriteLine("Enter a number to divide the above list by:");
                float numDivide = float.Parse(Console.ReadLine());
                //If statement to check if the user input is zero
                if (numDivide == 0)
                {
                    Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
                }
                else
                {
                    foreach (int num in intList)
                    {
                        float Divide = num / numDivide;
                        Console.WriteLine(num + " / " + numDivide + " = " + Divide);
                    }
                    numValid = true;
                }
            }
            //Catch block to display error message for string input
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }            
        }
        //Messsage to let the user know the program has exited the try/catch block
        Console.WriteLine("The program has executed the try/catch block.");
    }
}

using System;

namespace AbstractClassAssignment
{
    // Define an abstract class called Person
    // Abstract classes cannot be instantiated directly
    // They are meant to be inherited by other classes
    public abstract class Person
    {
        // Property to hold the person's first name
        public string FirstName { get; set; }

        // Property to hold the person's last name
        public string LastName { get; set; }

        // Abstract method declaration
        // This method must be implemented by any non-abstract class that inherits from Person
        public abstract void SayName();
    }

    // Employee class inherits from Person
    // Since Person has an abstract method, Employee must implement it
    public class Employee : Person
    {
        // Implement the abstract SayName() method
        public override void SayName()
        {
            // Print the full name to the console in the required format
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // Program class contains the Main method, the entry point of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee employee = new Employee();

            // Initialize the Employee's FirstName and LastName properties
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call the SayName() method on the Employee object
            // This will output: "Name: Sample Student"
            employee.SayName();

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
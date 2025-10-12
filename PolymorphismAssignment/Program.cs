using System;

namespace PolymorphismAssignment
{
    // Define an interface called IQuittable
    // Interfaces declare methods that must be implemented by any class that inherits them
    public interface IQuittable
    {
        // Method signature for Quit()
        void Quit();
    }

    // Abstract Person class from the previous drill
    // Abstract classes cannot be instantiated directly, but can provide base functionality
    public abstract class Person
    {
        // Property to hold the person's first name
        public string FirstName { get; set; }

        // Property to hold the person's last name
        public string LastName { get; set; }

        // Abstract method SayName() must be implemented by any derived class
        public abstract void SayName();
    }

    // Employee class inherits from Person and implements the IQuittable interface
    public class Employee : Person, IQuittable
    {
        // Implement the abstract SayName() method from Person
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            // For demonstration, simply print a message to the console
            Console.WriteLine(FirstName + " " + LastName + " has quit the job.");
        }
    }

    // Program class contains the Main method, the entry point of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object and initialize its properties
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the SayName() method to display the employee's full name
            employee.SayName();

            // Demonstrate polymorphism:
            // An Employee object can be treated as an IQuittable type
            IQuittable quittableEmployee = employee;

            // Call the Quit() method via the IQuittable interface reference
            // This shows polymorphism in action: the same object (Employee)
            // can be accessed through different types (Person, IQuittable)
            quittableEmployee.Quit();

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
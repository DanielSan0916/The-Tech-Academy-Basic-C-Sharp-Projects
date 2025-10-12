using System;

namespace ConstructorAssignment
{
    // Define a simple class called Person
    public class Person
    {
        // Property to hold the person's first name
        public string FirstName { get; set; }

        // Property to hold the person's last name
        public string LastName { get; set; }

        // -------------------------------
        // Constructor #1: Takes only a first name
        // -------------------------------
        public Person(string firstName)
        {
            FirstName = firstName;
            LastName = "Unknown"; // Default value if last name not provided
        }

        // -------------------------------
        // Constructor #2: Takes both first and last name
        // This constructor chains to the first constructor
        // -------------------------------
        public Person(string firstName, string lastName) : this(firstName)
        {
            LastName = lastName; // Override the default last name
        }

        // Method to display the full name
        public void DisplayFullName()
        {
            Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // Create a const variable
            // Const values cannot be changed after compilation
            // -------------------------------
            const string greeting = "Welcome to the Constructor Assignment!";

            // Print the const variable
            Console.WriteLine(greeting);

            // -------------------------------
            // Create a variable using the keyword 'var'
            // The compiler infers the type based on the assigned value
            // -------------------------------
            var number = 42; // Compiler infers this as an int

            Console.WriteLine("The value of 'number' is: " + number);

            // -------------------------------
            // Demonstrate constructor chaining
            // -------------------------------

            // Create a Person object using the constructor with one parameter
            Person person1 = new Person("Alice");
            person1.DisplayFullName(); // Output: "Full Name: Alice Unknown"

            // Create a Person object using the constructor with two parameters
            Person person2 = new Person("Bob", "Johnson");
            person2.DisplayFullName(); // Output: "Full Name: Bob Johnson"

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}

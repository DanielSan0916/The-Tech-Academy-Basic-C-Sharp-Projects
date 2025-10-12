using System;

namespace InheritanceExample
{
    // The Person class represents a generic person with a first and last name
    public class Person
    {
        // Property to hold the person's first name
        public string FirstName { get; set; }

        // Property to hold the person's last name
        public string LastName { get; set; }

        // Method to display the person's full name in the console
        public void SayName()
        {
            // Concatenate FirstName and LastName and print them in the required format
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // The Employee class inherits from Person, meaning it has FirstName, LastName, and SayName()
    public class Employee : Person
    {
        // Additional property unique to Employee: an integer Id
        public int Id { get; set; }
    }

    // The Program class contains the Main method, which is the entry point of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new Employee object
            Employee employee = new Employee();

            // Initialize the Employee's FirstName and LastName properties
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Optionally, we could also set the Id property (not required by the instructions)
            employee.Id = 1;

            // Call the SayName() method inherited from the Person class
            // This will print "Name: Sample Student" to the console
            employee.SayName();

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
using System;

namespace OperatorsAssignment
{
    // Define the Employee class
    public class Employee
    {
        // Property to hold the employee's unique Id
        public int Id { get; set; }

        // Property to hold the employee's first name
        public string FirstName { get; set; }

        // Property to hold the employee's last name
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are the same instance, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null and the other is not, return false
            if ((object)emp1 == null || (object)emp2 == null)
                return false;

            // Compare the Id properties of both Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator as required (must be done in pairs with "==")
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals() to ensure consistency with the overloaded operators
        public override bool Equals(object obj)
        {
            // If the object is not an Employee, return false
            if (!(obj is Employee))
                return false;

            // Compare Ids for equality
            return this.Id == ((Employee)obj).Id;
        }

        // Override GetHashCode() to ensure consistent hashing when using collections
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }

    // Program class contains the Main method, the entry point of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "Sample",
                LastName = "Student"
            };

            // Instantiate the second Employee object and assign values
            Employee employee2 = new Employee()
            {
                Id = 1, // Same Id as employee1 to test equality
                FirstName = "Test",
                LastName = "User"
            };

            // Compare the two Employee objects using the overloaded "==" operator
            if (employee1 == employee2)
            {
                Console.WriteLine("Employee1 and Employee2 are considered equal (same Id).");
            }
            else
            {
                Console.WriteLine("Employee1 and Employee2 are NOT equal (different Ids).");
            }

            // Compare the two Employee objects using the overloaded "!=" operator
            if (employee1 != employee2)
            {
                Console.WriteLine("Employee1 and Employee2 are NOT equal (different Ids).");
            }
            else
            {
                Console.WriteLine("Employee1 and Employee2 are considered equal (same Id).");
            }

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}


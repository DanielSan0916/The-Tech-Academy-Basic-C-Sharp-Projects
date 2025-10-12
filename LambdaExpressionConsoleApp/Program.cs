using System;
using System.Collections.Generic;
using System.Linq; // Required for lambda expressions and LINQ methods

namespace LambdaExpressionAssignment
{
    // Define the Employee class with three properties
    public class Employee
    {
        // Unique identifier for the employee
        public int Id { get; set; }

        // Employee's first name
        public string FirstName { get; set; }

        // Employee's last name
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees
            // At least two employees must have the first name "Joe"
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Mary", LastName = "Williams" },
                new Employee { Id = 5, FirstName = "John", LastName = "Brown" },
                new Employee { Id = 6, FirstName = "Anna", LastName = "Davis" },
                new Employee { Id = 7, FirstName = "Mike", LastName = "Miller" },
                new Employee { Id = 8, FirstName = "Sarah", LastName = "Wilson" },
                new Employee { Id = 9, FirstName = "David", LastName = "Moore" },
                new Employee { Id = 10, FirstName = "Laura", LastName = "Taylor" }
            };

            // -------------------------------
            // Using a foreach loop to find all employees with the first name "Joe"
            // -------------------------------
            List<Employee> joesForeach = new List<Employee>(); // Create a new list to hold results

            foreach (Employee emp in employees) // Loop through each employee in the list
            {
                if (emp.FirstName == "Joe") // Check if the FirstName property equals "Joe"
                {
                    joesForeach.Add(emp); // Add the employee to the new list
                }
            }

            // Display results from the foreach loop
            Console.WriteLine("Employees named Joe (using foreach loop):");
            foreach (Employee joe in joesForeach)
            {
                Console.WriteLine("Id: " + joe.Id + ", Name: " + joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine(); // Blank line for readability

            // -------------------------------
            // Using a lambda expression to find all employees with the first name "Joe"
            // -------------------------------
            List<Employee> joesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

            // Display results from the lambda expression
            Console.WriteLine("Employees named Joe (using lambda expression):");
            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine("Id: " + joe.Id + ", Name: " + joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine(); // Blank line for readability

            // -------------------------------
            // Using a lambda expression to find all employees with Id greater than 5
            // -------------------------------
            List<Employee> idGreaterThanFive = employees.Where(emp => emp.Id > 5).ToList();

            // Display results from the lambda expression
            Console.WriteLine("Employees with Id greater than 5:");
            foreach (Employee emp in idGreaterThanFive)
            {
                Console.WriteLine("Id: " + emp.Id + ", Name: " + emp.FirstName + " " + emp.LastName);
            }

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}

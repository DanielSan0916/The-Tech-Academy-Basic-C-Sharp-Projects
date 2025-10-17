using System;

namespace StudentCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // "using" ensures the context is disposed of properly after use.
            using (var context = new StudentContext())
            {
                // Create a new Student object in memory.
                var student = new Student
                {
                    StudentName = "John Doe" // This will be saved into the database.
                };

                // Add the student object to the context's Students collection.
                context.Students.Add(student);

                // SaveChanges() writes the new student into the database.
                context.SaveChanges();

                // Confirm to the user that the operation succeeded.
                Console.WriteLine("Student saved successfully!");
            }

            // Keeps the console window open until a key is pressed.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
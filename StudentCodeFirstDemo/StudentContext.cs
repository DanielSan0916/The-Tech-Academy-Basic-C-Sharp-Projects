using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Required for DbContext and DbSet

namespace StudentCodeFirstDemo
{
    // This class manages the connection to the database.
    // It inherits from DbContext, which is the EF base class for working with data.
    public class StudentContext : DbContext
    {
        // DbSet<Student> tells EF to create a "Students" table.
        // Each row in the table corresponds to a Student object.
        public DbSet<Student> Students { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCodeFirstDemo
{
    // This class represents the "Student" entity in your domain model.
    // EF will create a "Students" table based on this class.
    public class Student
    {
        // EF treats "StudentId" as the primary key by convention.
        public int StudentId { get; set; }

        // This property will become a column in the Students table.
        public string StudentName { get; set; }
    }
}

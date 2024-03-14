using System.Collections.Generic;

namespace MyWebApi.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}


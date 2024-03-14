using System.Collections.Generic;

namespace MyWebApi.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}


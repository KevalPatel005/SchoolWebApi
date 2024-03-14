using System.Collections.Generic;

namespace MyWebApi.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}


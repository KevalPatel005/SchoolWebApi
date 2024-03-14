using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MyWebApi.Models
{
public class SchoolContext : IdentityDbContext<IdentityUser>
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Classroom> Classrrom { get; set; }

        public DbSet<Staff> Staff { get; set; }
	}
}

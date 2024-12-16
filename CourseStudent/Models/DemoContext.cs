using Microsoft.EntityFrameworkCore;

namespace CourseStudent.Models
{
    public class DemoContext:DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = SRVMIO;" +
                    "initial catalog=CourseStudents; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true");
        }

    }
}

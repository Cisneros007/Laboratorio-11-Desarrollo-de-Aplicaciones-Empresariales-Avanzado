using Microsoft.EntityFrameworkCore;

namespace Api_Lab11.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1507-10\\SQLEXPRESS02; Database=APIDemoB2; Integrated Security=True;Trust Server Certificate=True ");
        }
    }
}
    

using Microsoft.EntityFrameworkCore;

namespace ManyToManyEF.Models
{
    public class RankenContext : DbContext
    {
        public RankenContext(DbContextOptions<RankenContext> options) : base(options)
        {
        }

        //These properties create our DB Tables
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "John Doe", FinancialAidStatus = "Passed" },
                new Student { StudentId = 2, Name = "Jane Doe", FinancialAidStatus = "Passed" },
                new Student { StudentId = 3, Name = "Bobby Gibson", FinancialAidStatus = "Passed" },
                new Student { StudentId = 4, Name = "Chuck Noris", FinancialAidStatus = "Passed" }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, Title = "Web Development Fundamentals" },
                new Course { CourseId = 2, Title = "Programming Fundamentals" },
                new Course { CourseId = 3, Title = "Full Stack with JS" },
                new Course { CourseId = 4, Title = "Full Stack with MS" }
                );

            modelBuilder.Entity<Student>().HasMany(s => s.Courses).WithMany(c => c.Students).UsingEntity(sc => sc.HasData(
                    new { CoursesCourseId = 1, StudentsStudentId = 1},
                    new { CoursesCourseId = 1, StudentsStudentId = 2 },
                    new { CoursesCourseId = 1, StudentsStudentId = 3 },
                    new { CoursesCourseId = 1, StudentsStudentId = 4 },
                    new { CoursesCourseId = 2, StudentsStudentId = 1 },
                    new { CoursesCourseId = 2, StudentsStudentId = 2 },
                    new { CoursesCourseId = 2, StudentsStudentId = 3 }
                ));
        }
    }
}

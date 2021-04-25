using Microsoft.EntityFrameworkCore;
using UniversityAutomationSystem.DataAccess.Models;

namespace UniversityAutomationSystem.DataAccess
{
    public sealed class DatabaseContext : DbContext
    {
        public DbSet<Credentials> Credentials { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<AcademicPerformance> AcademicPerformance { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<AssessmentType> AssessmentType { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<DeansOfficeWorker> DeansOfficeWorker { get; set; }
        public DbSet<FacultyDepartment> FacultyDepartment { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<PassingHistory> PassingHistory { get; set; }
        public DbSet<Specialty> Specialty { get; set; }
        public DbSet<TeacherType> TeacherType { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<SubjectTeacher> SubjectTeacher { get; set; }

        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                $@"Server=localhost\SQLEXPRESS;Database=UniversityAutomationSystem;Trusted_Connection=True;", b =>
                    b.MigrationsAssembly("UniversityAutomationSystem"));
        }
    }
}

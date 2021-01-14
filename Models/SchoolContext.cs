using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVC_CRUD.Models
{
    public class SchoolContext:DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {
              
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<ClassroomStudent>().HasKey(cs => new { cs.ClassroomId, cs.StudentId });
            modelBuilder.Entity<StudentGuardian>().HasKey(sg => new { sg.StudentId, sg.GuardianId });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<ClassroomStudent> ClassroomStudents { get; set; }
        public DbSet<StudentGuardian> StudentGuardians { get; set; }

    }
}

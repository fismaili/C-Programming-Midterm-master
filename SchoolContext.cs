using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplexDataModel.Models;
using Microsoft.EntityFrameworkCore;

namespace ComplexDataModel
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Models.Enrollment> Enrollments { get; set; }
        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }

    }

    }

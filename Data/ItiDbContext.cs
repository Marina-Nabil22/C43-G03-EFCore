using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Data
{
    internal class ItiDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=NewITI;Trusted_Connection=true;TrustServerCertificate = True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Department> Departments { get; set; }
   
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Course> Courses { get; set; }
    
        public DbSet<Topic> Topics { get; set; }
    

    }
}

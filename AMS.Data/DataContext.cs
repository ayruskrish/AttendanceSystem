using AMS.Models;
using AMS.Data.Configuration;
using System;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace AMS.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public static string ConnectionStringName
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionStringName"]
                    != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionStringName"].ToString();
                }
                return "DefaultConnection";
            }
        }
        static DataContext()
        {
            Database.SetInitializer(new CustomDatabaseIntializer());
        }
        public DataContext()
            : base(nameOrConnectionString: DataContext.ConnectionStringName)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AttendanceConfiguration());
            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new SemesterConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new TeacherConfiguration());
        }
        private void ApplyRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in this.ChangeTracker.Entries()
                        .Where(
                             e => e.Entity is IAuditInfo &&     // Search for All items that immpliment IAuditInfo
                            (e.State == EntityState.Added) ||   // State of an Entity
                            (e.State == EntityState.Modified))) // State of an Entity
            {
                IAuditInfo e = (IAuditInfo)entry.Entity;


                // if something's being added
                if (entry.State == EntityState.Added)
                {
                    e.ModifiedOn = DateTime.Now;
                }

                e.ModifiedOn = DateTime.Now;
            }
        }
        public override int SaveChanges()
        {
            this.ApplyRules();
            return base.SaveChanges();
        }
    }
}

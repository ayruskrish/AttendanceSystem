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
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}

using AMS.Models;
using System.Data.Entity.ModelConfiguration;

namespace AMS.Data.Configuration
{
    public class CourseConfiguration:EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {

        }
    }
}

using AMS.Models;
using System.Data.Entity.ModelConfiguration;

namespace AMS.Data.Configuration
{
    public class StudentConfiguration:EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {

        }
    }
}

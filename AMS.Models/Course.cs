using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMS.Models
{
    public class Course
    {
        public int Id { get; set;}
        public string CourseName { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Semester> Semesters { get; set; }
    }
}

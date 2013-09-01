﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AMS.Models
{
    public class Semester
    {
        [Required]
        public int Id { get; set; }
        public int NumberOfSemesters { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}

﻿using StudentAttendance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMS.Models
{
    public class Student : Person,IAuditInfo
    {
        public int CourseId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual Course Course { get; set; }
    }
}

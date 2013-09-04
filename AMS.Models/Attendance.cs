using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMS.Models
{
    public class Attendance : IAuditInfo
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public bool IsPresent { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        //Foregin Keys
        public virtual Student Student { get; set; }
    }
}

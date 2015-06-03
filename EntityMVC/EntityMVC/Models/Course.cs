//using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Web;

namespace EntityMVC.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        [MaxLength(256)]
        public string Url { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
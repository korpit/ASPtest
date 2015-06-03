using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EntityMVC.Migrations;
/*using System.Linq;
using System.Web;
*/
namespace EntityMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        [MaxLength(256)]
        public string Url { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
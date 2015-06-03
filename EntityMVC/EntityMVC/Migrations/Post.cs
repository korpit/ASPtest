using EntityMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityMVC.Migrations
{
    public class Post
    {
        public int PostId { get; set; }
        [MaxLength(256)]

        public string Title { get; set; }
        public string Content { get; set; }

        public int ID { get; set; }
        public Student Student { get; set; } 
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectProjects.Models
{
    public class Project
    {
        [Key]
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        [ForeignKey("ProjectTypeID")]
        public ProjectType Type { get; set; }
        public string UserStory { get; set; }

        public DateTime Deadline { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }




    }
}
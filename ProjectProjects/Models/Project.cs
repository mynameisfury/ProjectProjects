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

        public int ProjectTypeID { get; set; }
        [ForeignKey("ProjectTypeID")]
        public virtual ProjectType Type { get; set; }

        public int UserStoryID { get; set; }
        [ForeignKey("UserStoryID")]
        public virtual ICollection<UserStory> UserStory { get; set; }

        public DateTime Deadline { get; set; }




    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectProjects.Models
{
    public class UserStory
    {
        [Key]
        public int ID { get; set; }
        public string StoryName { get; set; }
        public string StoryText { get; set; }
        [ForeignKey("ProjectID")]
        public int ProjectID { get; set; }
    }
}
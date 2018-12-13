using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectProjects.Models
{
    public class ProjectType
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
    }
}
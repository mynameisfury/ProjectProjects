using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectProjects.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserID { get; set; }


    }
}
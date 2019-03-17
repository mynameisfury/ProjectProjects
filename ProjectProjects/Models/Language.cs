using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectProjects.Models
{
    public class Language
    {
        [Key]
        public int ID { get; set; }
        public string LanguageName { get; set; }
        public string LanguageOverview { get; set; }

        public int ProjectTypeID { get; set; }
        [ForeignKey("ProjectTypeID")]
        public virtual ProjectType LanguageUses { get; set; }

    }
}
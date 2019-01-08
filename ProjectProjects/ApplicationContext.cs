using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectProjects
{
    public class ApplicationContext : DbContext
    {
        public System.Data.Entity.DbSet<ProjectProjects.Models.Project> Projects { get; set; }
        public System.Data.Entity.DbSet<ProjectProjects.Models.ProjectType> ProjectTypes { get; set; }
    }
}
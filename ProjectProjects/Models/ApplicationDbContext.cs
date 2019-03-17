using System.Data.Entity;

namespace ProjectProjects.Models
{
    internal class ApplicationDbContext : DbContext
    {
        public System.Data.Entity.DbSet<ProjectProjects.Models.Language> Languages { get; set; }
        public System.Data.Entity.DbSet<ProjectProjects.Models.UserStory> UserStories { get; set; }
        public System.Data.Entity.DbSet<ProjectProjects.Models.Project> Projects { get; set; }
        public System.Data.Entity.DbSet<ProjectProjects.Models.ProjectType> ProjectTypes { get; set; }


    }
}
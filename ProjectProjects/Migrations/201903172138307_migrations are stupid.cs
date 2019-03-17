namespace ProjectProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationsarestupid : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LanguageName = c.String(),
                        LanguageOverview = c.String(),
                        ProjectTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProjectTypes", t => t.ProjectTypeID, cascadeDelete: true)
                .Index(t => t.ProjectTypeID);
            
            CreateTable(
                "dbo.ProjectTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        ProjectDescription = c.String(),
                        ProjectTypeID = c.Int(nullable: false),
                        UserStoryID = c.Int(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProjectTypes", t => t.ProjectTypeID, cascadeDelete: true)
                .Index(t => t.ProjectTypeID);
            
            CreateTable(
                "dbo.UserStories",
                c => new
                    {
                        UserStoryID = c.Int(nullable: false),
                        StoryName = c.String(),
                        StoryText = c.String(),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserStoryID)
                .ForeignKey("dbo.Projects", t => t.UserStoryID)
                .Index(t => t.UserStoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserStories", "UserStoryID", "dbo.Projects");
            DropForeignKey("dbo.Projects", "ProjectTypeID", "dbo.ProjectTypes");
            DropForeignKey("dbo.Languages", "ProjectTypeID", "dbo.ProjectTypes");
            DropIndex("dbo.UserStories", new[] { "UserStoryID" });
            DropIndex("dbo.Projects", new[] { "ProjectTypeID" });
            DropIndex("dbo.Languages", new[] { "ProjectTypeID" });
            DropTable("dbo.UserStories");
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectTypes");
            DropTable("dbo.Languages");
        }
    }
}

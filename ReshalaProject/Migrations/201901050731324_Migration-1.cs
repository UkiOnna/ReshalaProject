namespace ReshalaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskModels",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Cabinet = c.String(),
                        Commentario = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        IsComplete = c.Boolean(nullable: false),
                        Creator_Id = c.String(maxLength: 128),
                        Executor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Creator_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Executor_Id)
                .Index(t => t.Creator_Id)
                .Index(t => t.Executor_Id);
            
            AddColumn("dbo.AspNetUsers", "isTech", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskModels", "Executor_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TaskModels", "Creator_Id", "dbo.AspNetUsers");
            DropIndex("dbo.TaskModels", new[] { "Executor_Id" });
            DropIndex("dbo.TaskModels", new[] { "Creator_Id" });
            DropColumn("dbo.AspNetUsers", "isTech");
            DropTable("dbo.TaskModels");
        }
    }
}

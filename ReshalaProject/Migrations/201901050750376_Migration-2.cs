namespace ReshalaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TaskModels", newName: "UserTasks");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserTasks", newName: "TaskModels");
        }
    }
}

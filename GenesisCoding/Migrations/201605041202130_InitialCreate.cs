namespace GenesisCoding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ConfirmationToken", c => c.String());
            AddColumn("dbo.AspNetUsers", "IsConfirmed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsConfirmed");
            DropColumn("dbo.AspNetUsers", "ConfirmationToken");
        }
    }
}

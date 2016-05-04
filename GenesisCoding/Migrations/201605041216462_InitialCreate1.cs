namespace GenesisCoding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "ConfirmationToken");
            DropColumn("dbo.AspNetUsers", "IsConfirmed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "IsConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "ConfirmationToken", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
        }
    }
}

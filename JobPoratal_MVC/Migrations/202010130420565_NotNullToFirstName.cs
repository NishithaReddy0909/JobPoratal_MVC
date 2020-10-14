namespace JobPoratal_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotNullToFirstName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserDetails", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.UserDetails", "FirstName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.UserDetails", "LastName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.UserDetails", "Address", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.UserDetails", "MobileNumber", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.UserDetails", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.UserDetails", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.UserDetails", "Qualification", c => c.String(nullable: false));
            DropColumn("dbo.UserDetails", "UploadResume");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserDetails", "UploadResume", c => c.Binary());
            AlterColumn("dbo.UserDetails", "Qualification", c => c.String());
            AlterColumn("dbo.UserDetails", "Gender", c => c.String());
            AlterColumn("dbo.UserDetails", "Email", c => c.String());
            AlterColumn("dbo.UserDetails", "MobileNumber", c => c.String());
            AlterColumn("dbo.UserDetails", "Address", c => c.String());
            AlterColumn("dbo.UserDetails", "LastName", c => c.String());
            AlterColumn("dbo.UserDetails", "FirstName", c => c.String());
            DropColumn("dbo.UserDetails", "Discriminator");
        }
    }
}

namespace AMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewChangesMade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Family", c => c.String(nullable: false));
            AddColumn("dbo.Students", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Courses", "CourseName", c => c.String());
            AddColumn("dbo.Teachers", "Family", c => c.String(nullable: false));
            AddColumn("dbo.Teachers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Age", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Teachers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "Age", c => c.DateTime(nullable: false));
            DropColumn("dbo.Students", "DateOfBirth");
            DropColumn("dbo.Courses", "Name");
            DropColumn("dbo.Teachers", "DateOfBirth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "Name", c => c.String());
            AddColumn("dbo.Students", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Teachers", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.Teachers", "Name", c => c.String());
            AlterColumn("dbo.Students", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String());
            DropColumn("dbo.Teachers", "Email");
            DropColumn("dbo.Teachers", "Family");
            DropColumn("dbo.Courses", "CourseName");
            DropColumn("dbo.Students", "Email");
            DropColumn("dbo.Students", "Family");
        }
    }
}

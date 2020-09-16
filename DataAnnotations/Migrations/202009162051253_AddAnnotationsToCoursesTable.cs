namespace DataAnnotations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsToCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            RenameColumn(table: "dbo.Courses", name: "Author_Id", newName: "AuthotId");
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.Courses", "AuthotId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "AuthotId");
            AddForeignKey("dbo.Courses", "AuthotId", "dbo.Authors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "AuthotId", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "AuthotId" });
            AlterColumn("dbo.Courses", "AuthotId", c => c.Int());
            AlterColumn("dbo.Courses", "Description", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
            RenameColumn(table: "dbo.Courses", name: "AuthotId", newName: "Author_Id");
            CreateIndex("dbo.Courses", "Author_Id");
            AddForeignKey("dbo.Courses", "Author_Id", "dbo.Authors", "Id");
        }
    }
}

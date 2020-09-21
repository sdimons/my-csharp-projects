namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnhanceVideosTableAndGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.Videos DROP CONSTRAINT DF__Videos__Classifi__3B75D760");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            RenameColumn(table: "dbo.Videos", name: "Genre_Id", newName: "GenreId");
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Classification", c => c.Byte(nullable: false));
            AlterColumn("dbo.Videos", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Videos", "GenreId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Videos", new[] { "GenreId" });
            AlterColumn("dbo.Videos", "GenreId", c => c.Int());
            AlterColumn("dbo.Videos", "Classification", c => c.Int(nullable: false));
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            RenameColumn(table: "dbo.Videos", name: "GenreId", newName: "Genre_Id");
            CreateIndex("dbo.Videos", "Genre_Id");
        }
    }
}

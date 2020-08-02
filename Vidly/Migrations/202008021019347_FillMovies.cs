namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, CreateDate, NumberInStock) VALUES ('Hangover', 1, '20091106', '20160504', 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, CreateDate, NumberInStock) VALUES ('Die Hard', 2, '20091106', '20160504', 4)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, CreateDate, NumberInStock) VALUES ('The Terminator', 2, '19841106', '20160504', 6)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, CreateDate, NumberInStock) VALUES ('Toy Story', 3, '20121106', '20160504', 2)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, CreateDate, NumberInStock) VALUES ('Titanic', 4, '20071106', '20160504', 8)");
        }
        
        public override void Down()
        {
        }
    }
}

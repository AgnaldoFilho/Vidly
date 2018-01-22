namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES ('Hangover',1,'11/6/2009','5/4/2016',5)");
        }
        
        public override void Down()
        {
        }
    }
}

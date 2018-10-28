namespace BestMovies.Migrations
{
    using BestMovies.DB;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addgenres : DbMigration
    {
        public override void Up()
        {
            using (var context = new BestMoviesDBContext())
            {
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (Name)"
                    + " VALUES ('Comedy')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (Name)"
                    + " VALUES ('Action')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (Name)"
                    + " VALUES ('Drama')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (Name)"
                    + " VALUES ('Horror')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (Name)"
                    + " VALUES ('Fantasy')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (Name)"
                    + " VALUES ('Sci-fi')"
                    );
            }
        }
        
        public override void Down()
        {
        }
    }
}

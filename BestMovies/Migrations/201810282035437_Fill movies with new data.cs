namespace BestMovies.Migrations
{
    using BestMovies.DB;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fillmovieswithnewdata : DbMigration
    {
        public override void Up()
        {
            using (var context = new BestMoviesDBContext())
            {
                context.Database.ExecuteSqlCommand(
                    "UPDATE dbo.Movies SET Genre_Id = 1,"
                    + " ReleaseDate = '01/04/2005',"
                    + " AddedOn = '10/28/2018',"
                    + " NumberInStock = 5"
                    + " WHERE Id = 1"
                    );
                context.Database.ExecuteSqlCommand(
                    "UPDATE dbo.Movies SET Genre_Id = 2,"
                    + " ReleaseDate = '10/07/2012',"
                    + " AddedOn = '10/28/2018',"
                    + " NumberInStock = 13"
                    + " WHERE Id = 2"
                    );
            }
        }
        
        public override void Down()
        {
        }
    }
}

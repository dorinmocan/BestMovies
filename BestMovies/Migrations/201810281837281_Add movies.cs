namespace BestMovies.Migrations
{
    using BestMovies.DB;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addmovies : DbMigration
    {
        public override void Up()
        {
            using (var context = new BestMoviesDBContext())
            {
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Movies (Title)"
                    + " VALUES ('Shrek!')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Movies (Title)"
                    + " VALUES ('Mr. and Msr. Smith')"
                    );
            }
        }
        
        public override void Down()
        {
        }
    }
}

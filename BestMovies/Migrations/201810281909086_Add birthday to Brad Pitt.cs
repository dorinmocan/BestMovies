namespace BestMovies.Migrations
{
    using BestMovies.DB;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddbirthdaytoBradPitt : DbMigration
    {
        public override void Up()
        {
            using (var context = new BestMoviesDBContext())
            {
                context.Database.ExecuteSqlCommand(
                    "UPDATE dbo.Customers SET DateOfBirth = '12/18/1963'"
                    + " WHERE Id = 1"
                    );
            }
        }
        
        public override void Down()
        {
        }
    }
}

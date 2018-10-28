namespace BestMovies.Migrations
{
    using BestMovies.DB;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addcustomers : DbMigration
    {
        public override void Up()
        {
            using (var context = new BestMoviesDBContext())
            {
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Customers (FirstName, LastName, IsSubscribedToNewsletter, MembershipType_Id)"
                    + " VALUES ('Brad', 'Pitt', 1, 1)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Customers (FirstName, LastName, IsSubscribedToNewsletter, MembershipType_Id)"
                    + " VALUES ('Angelina', 'Jolie', 1, 2)"
                    );
            }
        }
        
        public override void Down()
        {
        }
    }
}

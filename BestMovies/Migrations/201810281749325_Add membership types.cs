namespace BestMovies.Migrations
{
    using BestMovies.DB;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addmembershiptypes : DbMigration
    {
        public override void Up()
        {
            using (var context = new BestMoviesDBContext())
            {
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MembershipTypes (Name, SignUpFee, MonthsOfMembership, DiscountRate)"
                    + " VALUES ('Pay as You Go', 0, 0, 0)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MembershipTypes (Name, SignUpFee, MonthsOfMembership, DiscountRate)"
                    + " VALUES ('Monthly', 30, 1, 10)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MembershipTypes (Name, SignUpFee, MonthsOfMembership, DiscountRate)"
                    + " VALUES ('Quarterly', 90, 3, 15)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MembershipTypes (Name, SignUpFee, MonthsOfMembership, DiscountRate)"
                    + " VALUES ('Annual', 300, 12, 20)"
                    );
            }
        }
        
        public override void Down()
        {
        }
    }
}

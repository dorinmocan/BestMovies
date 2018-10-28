namespace BestMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Setbirthdayfieldasnullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}

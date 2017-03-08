namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateAndTimeToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Costumers", "BirthDateAndTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AddColumn("dbo.Costumers", "BirthDateAndTime", c => c.DateTime(nullable: false));
        }
    }
}

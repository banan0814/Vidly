namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToCostumer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Costumers", "isSubscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Costumers", "isSubscribedToNewsLetter");
        }
    }
}

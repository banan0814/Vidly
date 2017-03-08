namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        Discountrate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Costumers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Costumers", "MembershipTypeId");
            AddForeignKey("dbo.Costumers", "MembershipTypeId", "dbo.MembershipTypes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Costumers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Costumers", new[] { "MembershipTypeId" });
            DropColumn("dbo.Costumers", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}

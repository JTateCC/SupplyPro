namespace SupplyPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocationTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                    })
                .PrimaryKey(t => t.LocationId);

            Sql("INSERT INTO dbo.Locations (LocationName) VALUES ('A1')");
            Sql("INSERT INTO dbo.Locations (LocationName) VALUES ('B1')");
            AddColumn("dbo.Products", "LocationId", c => c.Int());
            Sql("UPDATE dbo.Products SET LocationId = 1");
            CreateIndex("dbo.Products", "LocationId");
            AddForeignKey("dbo.Products", "LocationId", "dbo.Locations", "LocationId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "LocationId", "dbo.Locations");
            DropIndex("dbo.Products", new[] { "LocationId" });
            DropColumn("dbo.Products", "LocationId");
            DropTable("dbo.Locations");
        }
    }
}

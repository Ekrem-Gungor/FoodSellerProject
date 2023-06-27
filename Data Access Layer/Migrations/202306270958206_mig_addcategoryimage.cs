namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addcategoryimage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoryİmage",
                c => new
                    {
                        İmageID = c.Int(nullable: false, identity: true),
                        İmageURL = c.String(maxLength: 250),
                        FoodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.İmageID)
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .Index(t => t.FoodID);
            
            DropColumn("dbo.Foods", "FoodImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "FoodImage", c => c.String(maxLength: 250));
            DropForeignKey("dbo.Categoryİmage", "FoodID", "dbo.Foods");
            DropIndex("dbo.Categoryİmage", new[] { "FoodID" });
            DropTable("dbo.Categoryİmage");
        }
    }
}

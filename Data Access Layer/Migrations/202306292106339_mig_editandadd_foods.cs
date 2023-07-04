namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_editandadd_foods : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderName = c.String(maxLength: 50),
                        OrderDetails = c.String(maxLength: 200),
                        OrderStatus = c.String(),
                        FoodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .Index(t => t.FoodID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "FoodID", "dbo.Foods");
            DropIndex("dbo.Orders", new[] { "FoodID" });
            DropTable("dbo.Orders");
        }
    }
}

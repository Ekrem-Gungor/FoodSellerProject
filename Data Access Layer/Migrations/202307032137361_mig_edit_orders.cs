namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit_orders : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "FoodID", "dbo.Foods");
            DropIndex("dbo.Orders", new[] { "FoodID" });
            DropTable("dbo.Orders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderName = c.String(maxLength: 50),
                        OrderDetails = c.String(maxLength: 200),
                        OrderDate = c.DateTime(nullable: false),
                        OrderStatus = c.String(),
                        FoodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateIndex("dbo.Orders", "FoodID");
            AddForeignKey("dbo.Orders", "FoodID", "dbo.Foods", "FoodID", cascadeDelete: true);
        }
    }
}

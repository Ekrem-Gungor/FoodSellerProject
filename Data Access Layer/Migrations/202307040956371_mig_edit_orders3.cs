namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit_orders3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "Foods_FoodID", "dbo.Foods");
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.Orders", new[] { "Foods_FoodID" });
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
                        CustomerID = c.Int(nullable: false),
                        FoodsID = c.Int(nullable: false),
                        Foods_FoodID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateIndex("dbo.Orders", "Foods_FoodID");
            CreateIndex("dbo.Orders", "CustomerID");
            AddForeignKey("dbo.Orders", "Foods_FoodID", "dbo.Foods", "FoodID");
            AddForeignKey("dbo.Orders", "CustomerID", "dbo.Customers", "CustomerID", cascadeDelete: true);
        }
    }
}

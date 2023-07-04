namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit_orders4 : DbMigration
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
                        OrderDate = c.DateTime(nullable: false),
                        OrderStatus = c.String(),
                        CustomerID = c.Int(nullable: false),
                        FoodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.FoodID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "FoodID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropTable("dbo.Orders");
        }
    }
}

namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_editcategoryimage : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categoryİmage", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.Foods", "OrderID", "dbo.Orders");
            DropIndex("dbo.Foods", new[] { "OrderID" });
            DropIndex("dbo.Categoryİmage", new[] { "FoodID" });
            DropColumn("dbo.Foods", "OrderID");
            DropColumn("dbo.Categoryİmage", "FoodID");
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
                        Orderİmage = c.String(maxLength: 200),
                        OrderStatus = c.String(),
                    })
                .PrimaryKey(t => t.OrderID);
            
            AddColumn("dbo.Categoryİmage", "FoodID", c => c.Int(nullable: false));
            AddColumn("dbo.Foods", "OrderID", c => c.Int(nullable: false));
            CreateIndex("dbo.Categoryİmage", "FoodID");
            CreateIndex("dbo.Foods", "OrderID");
            AddForeignKey("dbo.Foods", "OrderID", "dbo.Orders", "OrderID", cascadeDelete: true);
            AddForeignKey("dbo.Categoryİmage", "FoodID", "dbo.Foods", "FoodID", cascadeDelete: true);
        }
    }
}

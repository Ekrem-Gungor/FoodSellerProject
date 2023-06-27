namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_orders_iliskileri : DbMigration
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
                        Orderİmage = c.String(maxLength: 200),
                        OrderStatus = c.String(),
                    })
                .PrimaryKey(t => t.OrderID);
            
            AddColumn("dbo.Foods", "OrderID", c => c.Int(nullable: false));
            CreateIndex("dbo.Foods", "OrderID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "OrderID", "dbo.Orders");
            DropIndex("dbo.Foods", new[] { "OrderID" });
            DropColumn("dbo.Foods", "OrderID");
            DropTable("dbo.Orders");
        }
    }
}

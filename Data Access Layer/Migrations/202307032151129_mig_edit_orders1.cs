namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit_orders1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "FoodsID", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Foods_FoodID", c => c.Int());
            CreateIndex("dbo.Orders", "Foods_FoodID");
            AddForeignKey("dbo.Orders", "Foods_FoodID", "dbo.Foods", "FoodID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Foods_FoodID", "dbo.Foods");
            DropIndex("dbo.Orders", new[] { "Foods_FoodID" });
            DropColumn("dbo.Orders", "Foods_FoodID");
            DropColumn("dbo.Orders", "FoodsID");
        }
    }
}

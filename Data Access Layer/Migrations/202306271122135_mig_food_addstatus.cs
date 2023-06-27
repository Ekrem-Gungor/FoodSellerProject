namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_food_addstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "FoodStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "FoodStatus");
        }
    }
}

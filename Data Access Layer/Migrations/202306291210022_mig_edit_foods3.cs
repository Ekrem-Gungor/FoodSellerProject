namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit_foods3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "FoodPDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Foods", "FoodMHistory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "FoodMHistory", c => c.DateTime(nullable: false));
            DropColumn("dbo.Foods", "FoodPDate");
        }
    }
}

namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit_foods1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Foods", "FoodSLT");
            DropColumn("dbo.Foods", "FoodMHistory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "FoodMHistory", c => c.DateTime(nullable: false));
            AddColumn("dbo.Foods", "FoodSLT", c => c.DateTime(nullable: false));
        }
    }
}

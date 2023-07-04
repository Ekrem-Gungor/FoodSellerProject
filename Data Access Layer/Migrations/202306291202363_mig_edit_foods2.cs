namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit_foods2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "FoodSLT", c => c.DateTime(nullable: false));
            AddColumn("dbo.Foods", "FoodMHistory", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "FoodMHistory");
            DropColumn("dbo.Foods", "FoodSLT");
        }
    }
}

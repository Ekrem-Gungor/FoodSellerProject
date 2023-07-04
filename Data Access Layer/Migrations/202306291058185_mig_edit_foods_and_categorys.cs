namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit_foods_and_categorys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryImageURL", c => c.String(maxLength: 250));
            AddColumn("dbo.Foods", "FoodLCD", c => c.String(maxLength: 20));
            AddColumn("dbo.Foods", "FoodSLT", c => c.String(maxLength: 20));
            AddColumn("dbo.Foods", "FoodMHistory", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "FoodMHistory");
            DropColumn("dbo.Foods", "FoodSLT");
            DropColumn("dbo.Foods", "FoodLCD");
            DropColumn("dbo.Categories", "CategoryImageURL");
        }
    }
}

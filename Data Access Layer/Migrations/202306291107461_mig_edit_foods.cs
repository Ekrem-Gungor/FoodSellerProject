namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit_foods : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Foods", "FoodImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "FoodImage", c => c.String(maxLength: 250));
        }
    }
}

namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "FoodImage", c => c.String(maxLength: 250));
            DropTable("dbo.Categoryİmage");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categoryİmage",
                c => new
                    {
                        İmageID = c.Int(nullable: false, identity: true),
                        İmageURL = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.İmageID);
            
            DropColumn("dbo.Foods", "FoodImage");
        }
    }
}

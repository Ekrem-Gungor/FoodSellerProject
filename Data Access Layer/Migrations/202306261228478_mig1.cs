namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ContactNo", c => c.String(maxLength: 50));
            DropColumn("dbo.Customers", "ContactName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "ContactName", c => c.String(maxLength: 50));
            DropColumn("dbo.Customers", "ContactNo");
        }
    }
}

namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_cust_addstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustStatus");
        }
    }
}

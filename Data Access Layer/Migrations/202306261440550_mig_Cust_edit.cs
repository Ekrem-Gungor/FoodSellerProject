namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_Cust_edit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerPassword", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerPassword", c => c.String(maxLength: 20));
        }
    }
}

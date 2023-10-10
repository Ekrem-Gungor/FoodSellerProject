namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_customermail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerMail", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerMail");
        }
    }
}

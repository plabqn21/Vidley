namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomer : DbMigration
    {
        public override void Up()
        {

            Sql("Update Customers set Birthday='2/3/2014' where id=1");
        }
        
        public override void Down()
        {
        }
    }
}

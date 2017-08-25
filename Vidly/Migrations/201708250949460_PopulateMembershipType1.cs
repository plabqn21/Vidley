namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType1 : DbMigration
    {
        public override void Up()
        {
            Sql("Update Membershiptypes set name='Pay per as Go' where id=1");
            Sql("Update Membershiptypes set name='Monthly' where id=2");
            Sql("Update Membershiptypes set name='Quatarly' where id=3");
            Sql("Update Membershiptypes set name='Yearly' where id=4");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres values('Comedy')");
            Sql("Insert into Genres values('Romance')");
            Sql("Insert into Genres values('Family')");
            Sql("Insert into Genres values('Action')");
           
        }
        
        public override void Down()
        {
        }
    }
}

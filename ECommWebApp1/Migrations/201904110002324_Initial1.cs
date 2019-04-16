namespace ECommWebApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EntryProducts", "ProductDescription", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EntryProducts", "ProductDescription", c => c.Int(nullable: false));
        }
    }
}

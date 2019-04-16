namespace ECommWebApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EntryCategories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryNo = c.String(),
                        CategoreyName = c.String(),
                        Parent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.EntryProducts",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductNo = c.String(),
                        ProductName = c.String(),
                        ProductDescription = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubCategory = c.Int(nullable: false),
                        Featured = c.String(),
                        MainCategoryID = c.Int(nullable: false),
                        PhotoID = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EntryProducts");
            DropTable("dbo.EntryCategories");
        }
    }
}

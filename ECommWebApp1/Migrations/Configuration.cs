namespace ECommWebApp1.Migrations
{
    using ECommWebApp1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ECommWebApp1.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ECommWebApp1.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // populate Categories table with data 
        
            context.EntryCategories.Add(new EntryCategory()  {CategoreyName = "Desktop",  CategoryID = 1, CategoryNo = "DT",
                 Parent = 0  });
            // populate Products table with data

            context.EntryProducts.Add(new EntryProduct() { Featured = "N", MainCategoryID = 1, PhotoID = "1",
            Price = 10.50m, ProductDescription = "Toshiba desktop", ProductID = 1, ProductName = "Toshiba Special edition",
            ProductNo = "Toshiba model 1", SubCategory = 5});


        }
    }
}

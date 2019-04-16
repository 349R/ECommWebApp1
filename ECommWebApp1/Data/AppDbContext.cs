using ECommWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommWebApp1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() :base("name=ProductDb")
        {

        }
        public DbSet<EntryCategory> EntryCategories { get; set; }
        public DbSet<EntryProduct> EntryProducts { get; set; }


    }
}
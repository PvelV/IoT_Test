using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IoT_Test.ClientWebApp
{
    public class AppDatabase : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<Message>().ToTable("Messages");
        }
    }
}
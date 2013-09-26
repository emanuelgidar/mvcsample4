using MvcApplication4.Persistante;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class MvcApplication4Context : DbContext
    {
        
        public DbSet<MvcApplication4.Models.Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MvcApplication4Context, Configuration>());
        }
    }
}
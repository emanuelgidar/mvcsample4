using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using MvcApplication4.Models;


namespace MvcApplication4.Persistante
{
    public class Configuration : DbMigrationsConfiguration<Test> 
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        
    }
}
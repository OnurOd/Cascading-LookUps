using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication.Data
{
    public class StorageMigration : DbMigrationsConfiguration<StorageContext>
    {
        public StorageMigration()
        {
            //db tablolarinda degiskligi anlayabilmek icin AutomaticMigrationsEnabled aktive edilmeli
            //veri kayiplarina neden olsa da kabul ediyoruz, AutomaticMigrationDataLossAllowed true
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication.Data
{
    public class StorageContext : DbContext
    {
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public StorageContext()
        {

        }
        public StorageContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StorageContext, StorageMigration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StorageContext>());
        }
    }
}

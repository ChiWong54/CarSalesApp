using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetSalesApp.Data
{
    public class AssetSalesDbContext : DbContext
    {
        public string DbPath { get; } // Will hold location of database filename

        public AssetSalesDbContext()
        {
            // set the database filename (inc. full path to the user's Documents folder)
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "assets.db");
        }

        // Specify the database table(s)
        public DbSet<Asset> Assets => Set<Asset>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Set the database filename(inc. path) for SQLite to use
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // execute the base OnModelCreating method

            // Add test data
            modelBuilder.Entity<Asset>().HasData(
                new Asset(1, "Asset1", "Location1", DateTime.Parse("2022-07-10"), true, 1234),
                new Asset(2, "Asset2", "Location2", DateTime.Parse("2022-07-13"), false, 4321),
                new Asset(3, "Asset3", "Location3", DateTime.Parse("2022-07-16"), true, 2345),
                new Asset(4, "Asset4", "Location4", DateTime.Parse("2022-07-18"), true, 5432),
                new Asset(5, "Asset5", "Location5", DateTime.Parse("2022-07-21"), false, 3456),
                new Asset(6, "Asset6", "Location6", DateTime.Parse("2022-07-23"), true, 6543),
                new Asset(7, "Asset7", "Location7", DateTime.Parse("2022-07-26"), false, 4567)
            );
        }
    }
}

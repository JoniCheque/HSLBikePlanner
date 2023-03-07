using Microsoft.EntityFrameworkCore;
using Repository.Entities;

namespace Repository.Contexts
{
    public class BicycleDataContext : DbContext
    {
        public DbSet<BicycleDataEntry> BicycleDataEntries { get; set; }

        public string DbPath { get; }

        public BicycleDataContext()
        {
            var folder = Environment.SpecialFolder.Desktop;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "bicycleDataEntries.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}

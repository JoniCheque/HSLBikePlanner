using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Contexts;
using System.ComponentModel;

namespace BicycleService
{
    public class Program
    {
        static void Main(string[] args)
        {
            var folder = Environment.SpecialFolder.Desktop;
            var path = Environment.GetFolderPath(folder);
            var dbPath = Path.Join(path, "bicycleDataEntries.db");

            var container = new Container();

            var _serviceProvider = new ServiceCollection()
                .AddDbContext<BicycleDataContext>()
                .BuildServiceProvider();
        }
    }
}
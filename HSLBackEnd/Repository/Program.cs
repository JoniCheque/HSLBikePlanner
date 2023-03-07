using Repository.Contexts;
using Repository.Entities;

namespace Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start seeding!");
            Console.WriteLine("Reading all the datasets:");


            var directories =
                Directory.GetDirectories("C:\\Users\\super\\koodit\\digitransit\\HSLBackEnd\\Repository\\Seeding\\DataFiles\\")
                .ToList();

            var allFiles = new List<string>();

            foreach (string directory in directories)
            {
                var folderFiles = Directory.GetFiles(directory).ToList();
                Console.WriteLine($"Directory: {directory}");

                foreach (var file in folderFiles)
                {
                    Console.WriteLine($"File: {file}");
                }

                allFiles.AddRange(folderFiles);
            }

            Console.WriteLine($"Total amount of all files: {allFiles.Count}");

            foreach (var file in allFiles)
            {
                using var db = new BicycleDataContext();
                Console.WriteLine($"Reading data from file: {file}");

                var bicycleDataEntries =
                    File.ReadAllLines(file)
                    .Skip(1)
                    .Select(line => BicycleDataEntry.FromCsv(line))
                    .Where(dataEntry => dataEntry != null)
                    .ToList();

                db.AddRange(bicycleDataEntries);
                db.SaveChanges();
                db.Dispose();
            }

            Console.WriteLine("All data read.");


            Console.ReadLine();
        }
    }
}
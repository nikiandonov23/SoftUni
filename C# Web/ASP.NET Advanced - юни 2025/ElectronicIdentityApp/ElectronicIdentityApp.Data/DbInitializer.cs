using ElectronicIdentityApp.Data.SeedData;
using ElectronicIdentityApp.DataModels;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace ElectronicIdentityApp.Data;

public static class DbInitializer
{
    public static void Seed(ApplicationDbContext context)
    {
        if (context.Addresses.Any())
        {
            Console.WriteLine("Addresses table already has data, skipping seeding.");
            return;
        }

        // Създавам абсолютен път спрямо изпълнимия файл
        var basePath = AppContext.BaseDirectory;
        var filePath = Path.Combine(basePath, "SeedData", "export.geojson");

     

        var json = File.ReadAllText(filePath);

        var data = JsonSerializer.Deserialize<FeatureCollection>(json);

        if (data?.Features == null || !data.Features.Any())
        {
            Console.WriteLine("No features found in JSON.");
            return;
        }

        int addedCount = 0;


        var cyrillicRegex = new Regex(@"[\u0400-\u04FF]");


        foreach (var feature in data.Features)
        {

            if (string.IsNullOrWhiteSpace(feature.Properties.City))
            {
                Console.WriteLine("Skipping feature with missing required fields (City).");
                continue;
            }

            if (string.IsNullOrWhiteSpace(feature.Properties.PostalCode))
            {
                Console.WriteLine("Skipping feature with missing required fields (PostalCode).");
                continue;
            }



            if ( string.IsNullOrWhiteSpace(feature.Properties.Street))
            {
                Console.WriteLine("Skipping feature with missing required fields (Street).");
                continue;
            }


            // проверка: City и Street трябва да съдържат поне една кирилска буква
            if (!cyrillicRegex.IsMatch(feature.Properties.City) ||
                !cyrillicRegex.IsMatch(feature.Properties.Street))
            {
                Console.WriteLine($"Skipping non-Cyrillic address: {feature.Properties.City}, {feature.Properties.Street}");
                continue;
            }


            context.Addresses.Add(new Address
            {
                City = feature.Properties.City,
                Street = feature.Properties.Street,
                HouseNumber = feature.Properties.HouseNumber,
                PostalCode = feature.Properties.PostalCode,
                HouseName = feature.Properties.Name,
                BuildingType = feature.Properties.BuildingType,
                
                
                
            });

            addedCount++;
        }

        context.SaveChanges();
        Console.WriteLine($"Seeded {addedCount} addresses.");
    }

}
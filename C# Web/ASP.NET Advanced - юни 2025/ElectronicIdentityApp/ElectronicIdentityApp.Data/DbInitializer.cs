using ElectronicIdentityApp.DataModels;
using System.Text.Json;
using ElectronicIdentityApp.Data.SeedData;

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

        foreach (var feature in data.Features)
        {
          
            
            // Проверяваме задължителните полета City и Street
            if (string.IsNullOrWhiteSpace(feature.Properties.City))
            {
                // Измишлотини прааа щото ми е тъп json файла ! 
                feature.Properties.City = "Русе";
            }

            if (string.IsNullOrWhiteSpace(feature.Properties.PostalCode) && feature.Properties.City=="Русе")
            {
                // Измишлотини прааа щото ми е тъп json файла ! 
                feature.Properties.PostalCode = "7000";
            }
            if ( string.IsNullOrWhiteSpace(feature.Properties.Street))
            {
                Console.WriteLine("Skipping feature with missing required fields (City or Street).");
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
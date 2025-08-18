using System.Text.Json.Serialization;

namespace ElectronicIdentityApp.Data.SeedData;

public class Properties
{
    [JsonPropertyName("addr:city")]
    public string? City { get; set; }


    [JsonPropertyName("addr:street")]
    public string? Street { get; set; }


    [JsonPropertyName("addr:housenumber")]
    public string? HouseNumber { get; set; }


    [JsonPropertyName("addr:postcode")]
    public string? PostalCode { get; set; }


    [JsonPropertyName("name")]
    public string? Name { get; set; }

    

    [JsonPropertyName("building")]
    public string? BuildingType { get; set; }


}
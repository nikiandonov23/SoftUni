using System.Text.Json.Serialization;

namespace ElectronicIdentityApp.Data.SeedData;

public class FeatureCollection
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }



    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; } = new();
}
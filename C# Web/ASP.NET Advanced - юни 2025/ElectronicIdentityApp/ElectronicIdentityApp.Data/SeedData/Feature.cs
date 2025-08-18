using System.Text.Json.Serialization;

namespace ElectronicIdentityApp.Data.SeedData;

public class Feature
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("properties")]
    public Properties Properties { get; set; } = null!;
    // Можеш да добавиш Geometry ако ще го използваш
}
using System.ComponentModel.DataAnnotations;

namespace ElectronicIdentityApp.DataModels;

public class Address
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string City { get; set; } = null!;

    [Required]
    public string Street { get; set; } = null!;

    public string? HouseNumber { get; set; }

    public string? HouseName { get; set; }

    public string? PostalCode { get; set; }

    public string? BuildingType { get; set; }

    public bool IsCurrent { get; set; }=false;

    
}
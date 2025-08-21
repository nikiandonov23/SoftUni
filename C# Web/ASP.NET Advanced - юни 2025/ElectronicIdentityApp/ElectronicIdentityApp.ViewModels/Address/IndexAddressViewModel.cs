namespace ElectronicIdentityApp.ViewModels.Address;

public class IndexAddressViewModel
{
    public int Id { get; set; }
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string? HouseNumber { get; set; }
    public string? HouseName { get; set; }
    public string? PostalCode { get; set; }
    public string? BuildingType { get; set; }
    public bool IsCurrent { get; set; }
}
using System.ComponentModel.DataAnnotations;
namespace ElectronicIdentityApp.DataModels;
using static GCommon.ValidationConstants;
public class Address
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MinLength(CityMinLength)]
    [MaxLength(CityMaxLength)]
    public string City { get; set; } = null!;

    [Required]
    [MinLength(StreetMinLength)]
    [MaxLength(StreetMaxLength)]
    public string Street { get; set; } = null!;


    [MinLength(HouseNumberMinLength)]
    [MaxLength(HouseNumberMaxLength)]
    public string? HouseNumber { get; set; }


    [MinLength(HouseNameMinLength)]
    [MaxLength(HouseNameMaxLength)]
    public string? HouseName { get; set; }


    [MinLength(PostalCodeLength)]
    [MaxLength(PostalCodeLength)]
    public string? PostalCode { get; set; }


    [MinLength(BuildingTypeMinLength)]
    [MaxLength(BuildingTypeMaxLength)]
    public string? BuildingType { get; set; }

    public bool IsCurrent { get; set; }=false;





}
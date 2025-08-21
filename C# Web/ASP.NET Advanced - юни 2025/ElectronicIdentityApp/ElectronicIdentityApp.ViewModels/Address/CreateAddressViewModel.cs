using System.ComponentModel.DataAnnotations;
using ElectronicIdentityApp.ViewModels.Address.Dropdowns;
using static ElectronicIdentityApp.GCommon.ValidationConstants;
namespace ElectronicIdentityApp.ViewModels.Address;

public class CreateAddressViewModel
{
    [Required]
    public int CityId { get; set; }
    public IEnumerable<CitiesDropDownViewModel> Cities { get; set; } =
        new HashSet<CitiesDropDownViewModel>();



    [Required]
    public int StreetId { get; set; }
    public IEnumerable<StreetsDropDownViewModel> Streets { get; set; } = 
        new HashSet<StreetsDropDownViewModel>();


    public int HouseNumberId { get; set; }
    public IEnumerable<HouseNumbersDropDownViewModel> HouseNumber { get; set; } =
        new HashSet<HouseNumbersDropDownViewModel>();



    public int? HouseNameId { get; set; }
    public IEnumerable<HouseNameDropDownViewModel> HouseNames { get; set; } =
        new List<HouseNameDropDownViewModel>();



    public int PostCodeId { get; set; }
    public IEnumerable<PostCodeDropDownViewModel> PostCodes { get; set; } =
        new HashSet<PostCodeDropDownViewModel>();


    
    public bool IsCurrent { get; set; } = false;


    [Required(ErrorMessage = "Moved In date is required.")]
    [DataType(DataType.Date)]
    public DateTime? MovedIn { get; set; }
    


    [DataType(DataType.Date)]
    public DateTime? MovedOut { get; set; }

}
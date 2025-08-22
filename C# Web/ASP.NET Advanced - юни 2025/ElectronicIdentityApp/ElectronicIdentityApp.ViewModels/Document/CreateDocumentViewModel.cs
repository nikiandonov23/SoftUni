using ElectronicIdentityApp.ViewModels.Address.Dropdowns;
using ElectronicIdentityApp.ViewModels.Document.Dropdowns;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace ElectronicIdentityApp.ViewModels.Document;

public class CreateDocumentViewModel
{
    [Required]
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;

    [Required]
    [DataType(DataType.Date)]
    public DateTime? BirthOn { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime? IssuedOn { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime? ExpiredOn { get; set; }

    [Required]
    [RegularExpression(@"^[A-Z]{1,2}\d{6,7}$",
        ErrorMessage = "Номерът на личния документ трябва да съдържа 1-2 букви и 6-7 цифри.")]
    public string DocumentNumber { get; set; } = null!;

    [Required]
    public int NationalityId { get; set; }
    public IEnumerable<CreateNationalityDocumentDropDownViewModel> Nationalities { get; set; } =
        new HashSet<CreateNationalityDocumentDropDownViewModel>();





    [Required]
    public int DocumentTypeId { get; set; }
    public IEnumerable<CreateDocumentTypeDropDownViewModel> DocumentType { get; set; } =
        new HashSet<CreateDocumentTypeDropDownViewModel>();


    public IFormFile? DocumentImage { get; set; } // за качване на снимка



    [Required]
    public string CityName { get; set; } = null!;
    public IEnumerable<CitiesDropDownViewModel> Cities { get; set; } = new HashSet<CitiesDropDownViewModel>();

    [Required]
    public string StreetName { get; set; } = null!;
    public IEnumerable<StreetsDropDownViewModel> Streets { get; set; } = new HashSet<StreetsDropDownViewModel>();

    public string? HouseNumber { get; set; }
    public IEnumerable<HouseNumbersDropDownViewModel> HouseNumbers { get; set; } = new HashSet<HouseNumbersDropDownViewModel>();

    public string? HouseName { get; set; }
    public IEnumerable<HouseNameDropDownViewModel> HouseNames { get; set; } = new HashSet<HouseNameDropDownViewModel>();

    public string? PostCode { get; set; }
    public IEnumerable<PostCodeDropDownViewModel> PostCodes { get; set; } = new HashSet<PostCodeDropDownViewModel>();

}
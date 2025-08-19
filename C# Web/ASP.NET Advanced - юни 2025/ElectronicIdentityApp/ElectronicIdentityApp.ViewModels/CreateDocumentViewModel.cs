using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace ElectronicIdentityApp.ViewModels;

public class CreateDocumentViewModel
{
    [Required]
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;

    [Required]
    [DataType(DataType.Date)]
    public DateTime BirthOn { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime IssuedOn { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime ExpiredOn { get; set; }

    [Required]
    [RegularExpression(@"^[A-Z]{1,2}\d{6,7}$",
        ErrorMessage = "Номерът на личния документ трябва да съдържа 1-2 букви и 6-7 цифри.")]
    public string DocumentNumber { get; set; } = null!;

    [Required]
    public int NationalityId { get; set; }
    public IEnumerable<CreateNationalityDocumentDropDownViewModel> Nationalities { get; set; } =
        new HashSet<CreateNationalityDocumentDropDownViewModel>();



    [Required]
    public int AddressId { get; set; }

    public IEnumerable<CreateDocumentAddressDropDownViewModel> Addresses { get; set; } =
        new HashSet<CreateDocumentAddressDropDownViewModel>();


    public IFormFile? DocumentImage { get; set; } // за качване на снимка
}
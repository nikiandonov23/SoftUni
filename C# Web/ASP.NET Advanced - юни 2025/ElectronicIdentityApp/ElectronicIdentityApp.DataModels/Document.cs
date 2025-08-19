using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ElectronicIdentityApp.GCommon.ValidationConstants;
namespace ElectronicIdentityApp.DataModels
{
    public class Document
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето Име е задължително.")]
        [MinLength(DocumentFirstNameMinLength, ErrorMessage = "Името трябва да е поне {1} символа.")]
        [MaxLength(DocumentFirstNameMaxLength, ErrorMessage = "Името не може да е повече от {1} символа.")]
        public string FirstName { get; set; } = null!;



        [Required(ErrorMessage = "Полето Презима е задължително.")]
        [MinLength(DocumentMiddleNameMinLength, ErrorMessage = "Средното име трябва да е поне {1} символа.")]
        [MaxLength(DocumentMiddleNameMaxLength, ErrorMessage = "Средното име не може да е повече от {1} символа.")]
        public string MiddleName { get; set; }= null!;





        [Required(ErrorMessage = "Полето Фамилия е задължително.")]
        [MinLength(DocumentLastNameMinLength, ErrorMessage = "Фамилията трябва да е поне {1} символа.")]
        [MaxLength(DocumentLastNameMaxLength, ErrorMessage = "Фамилията не може да е повече от {1} символа.")]
        public string LastName { get; set; } = null!;





        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; } = null!;
        public IdentityUser Owner { get; set; } = null!;




        [Required(ErrorMessage = "Полето Националност е задължително.")]
        [ForeignKey(nameof(Nationality))]
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; } = null!;




        [Required(ErrorMessage = "Полето Тип документ е задължително.")]
        [ForeignKey(nameof(DocumentType))]
        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; } = null!;





        [Required(ErrorMessage = "Полето Дата на раждане е задължително.")]
        [DataType(DataType.Date)]
        public DateTime BirthOn { get; set; }





        [Required(ErrorMessage = "Полето Валидност до е задължително.")]
        [DataType(DataType.Date)]
        public DateTime ExpiredOn { get; set; }





        [Required(ErrorMessage = "Полето Дата на издаване е задължително.")]
        [DataType(DataType.Date)]
        public DateTime IssuedOn { get; set; }





        [Required(ErrorMessage = "Полето Номер на документ е задължително.")]
        [MinLength(DocumentNumberMinLength, ErrorMessage = "Номерът на документа трябва да е поне {1} символа.")]
        [MaxLength(DocumentNumberMaxLength, ErrorMessage = "Номерът на документа не може да е повече от {1} символа.")]
        [RegularExpression(DocumentNumberRegex, ErrorMessage = "Номерът на личния документ трябва да съдържа 1-2 букви и 6-7 цифри.")]
        public string DocumentNumber { get; set; } = null!;





        [Required(ErrorMessage = "Полето Адрес е задължително.")]
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        public Address Address { get; set; } = null!;




        public bool IsValid { get; set; } = true;



        public string? ImageUrl { get; set; }

    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicIdentityApp.DataModels
{
    public class Document
    {

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;





        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; } = null!;
        public IdentityUser Owner { get; set; } = null!;




        [ForeignKey(nameof(Nationality))]
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; } = null!;



        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthOn { get; set; }



        [Required]
        [DataType(DataType.Date)]
        public DateTime ExpiredOn { get; set; }



        [Required]
        [DataType(DataType.Date)]
        public DateTime IssuedOn { get; set; }



        [Required]
        [RegularExpression(@"^[A-Z]{1,2}\d{6,7}$",
            ErrorMessage = "Номерът на личния документ трябва да съдържа 1-2 букви и 6-7 цифри.")]
        public string DocumentNumber { get; set; } = null!;



        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        public Address Address { get; set; } = null!;


        public bool IsValid { get; set; } = false;

    }
}

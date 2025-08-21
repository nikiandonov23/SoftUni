using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ElectronicIdentityApp.DataModels;


[PrimaryKey(nameof(UserId), nameof(AddressId))]
public class UserAddress
{

    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = null!;
    public IdentityUser User { get; set; } = null!;




    [ForeignKey(nameof(Address))]
    public int AddressId { get; set; }
    public Address Address { get; set; } = null!;


    public DateTime MovedIn { get; set; }
    public DateTime? MovedOut { get; set; }

    public bool IsCurrent = false;
}
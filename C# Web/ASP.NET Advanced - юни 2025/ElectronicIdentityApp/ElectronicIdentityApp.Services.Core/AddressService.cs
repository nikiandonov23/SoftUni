using ElectronicIdentityApp.Data;
using ElectronicIdentityApp.Services.Core.Contracts;
using ElectronicIdentityApp.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ElectronicIdentityApp.Services.Core;

public class AddressService(ApplicationDbContext context):IAddressService
{
    public async Task<IEnumerable<CreateDocumentAddressDropDownViewModel>> GetAllAddressesForCreateAsync()
    {
        var allAddresses = await context
            .Addresses
            .Select(x => new CreateDocumentAddressDropDownViewModel()
            {
                Id = x.Id,
                Name = x.City + " " + x.Street + " " + x.HouseNumber,
            }).ToListAsync();


        return allAddresses;
    }
}